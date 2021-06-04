using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NCT_Fashion.Configuration;
using NCT_Fashion.Models.DTOs.Requests;
using NCT_Fashion.Models.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NCT_Fashion.Controllers
{
    [Route("api/[controller]")] // api/authmanagement
    [ApiController]
    public class authManagementController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtConfig _jwtConfig;

        private readonly IConfiguration _configuration;

        public authManagementController(
            UserManager<IdentityUser> userManager,
            IOptionsMonitor<JwtConfig> optionsMonitor,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _jwtConfig = optionsMonitor.CurrentValue;
            _configuration = configuration;
        }

        //GET Method
        //[HttpGet]
        //public JsonResult Get()
        //{
        //    string query = @"select * from AspNetUsers";
        //    DataTable table = new DataTable();
        //    string sqlDataSource = _configuration.GetConnectionString("NCT_FashionContext");
        //    SqlDataReader myReader;
        //    using (SqlConnection myCon = new SqlConnection(sqlDataSource))
        //    {
        //        myCon.Open();
        //        using (SqlCommand myCommand = new SqlCommand(query, myCon))
        //        {
        //            myReader = myCommand.ExecuteReader();
        //            table.Load(myReader);

        //            myReader.Close();
        //            myCon.Close();
        //        }
        //    }

        //    return new JsonResult(table);
        //}

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto user)
        {
            // Kiểm tra xem yêu cầu đến có hợp lệ không
            if (ModelState.IsValid)
            {
                // kiểm tra xem người dùng có cùng email có tồn tại không
                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if (existingUser != null)
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        Errors = new List<string>() { "Email already in use" },
                        Success = false,
                    });
                }

                var newUser = new IdentityUser() { Email = user.Email, UserName = user.Username };
                var isCreated = await _userManager.CreateAsync(newUser, user.Password);
                if (isCreated.Succeeded)
                {

                    var jwtToken = GenerateJwtToken(newUser);
                    return Ok(new RegistrationResponse()
                    {
                        Success = true,
                        Token = jwtToken
                    });


                }
                else
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        Errors = isCreated.Errors.Select(x => x.Description).ToList(),
                        Success = false
                    });
                }
            }

            return BadRequest(new RegistrationResponse()
            {
                Success = false,
                Errors = new List<string>() { "Invalid payload" }
            });
        }

        //Login
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if (existingUser == null)
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        Errors = new List<string>() {
                                "Invalid login request"
                            },
                        Success = false
                    });
                }

                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.Password);

                if (!isCorrect)
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        Errors = new List<string>() {
                                "Invalid login request"
                            },
                        Success = false
                    });
                }

                var jwtToken = GenerateJwtToken(existingUser);

                return Ok(new RegistrationResponse()
                {
                    Success = true,
                    Token = jwtToken
                });
            }

            return BadRequest(new RegistrationResponse()
            {
                Errors = new List<string>() {
                        "Invalid payload"
                    },
                Success = false
            });
        }



        //Register
        private string GenerateJwtToken(IdentityUser user)
        {
            //Xác định và tạo mã JWT
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]{

                    new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),

                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

                }),

                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);

            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;

        }
    }
}
