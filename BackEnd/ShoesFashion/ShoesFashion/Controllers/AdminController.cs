using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ShoesFashion.Models.Entities;
using System.Data.SqlClient;
using System.Data;

namespace ShoesFashion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public AdminController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //GET Method
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                    select * from Admin";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DBConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }

        //GET by ID
        [Route("{id}")]
        [HttpGet]
        public JsonResult Get(int id)
        {
            string query = "select * from Admin where admin_id = " + id + @"";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DBConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }

        //POST Method
        [HttpPost]
        public JsonResult Post(Admin admin)
        {
            string query = @"insert into Admin(username, password, status, fullname , avatar, email, phone) values 
                (
                '" + admin.UserName + @"', 
                '" + admin.Password + @"', 
                '" + admin.Status + @"', 
                '" + admin.Fullname + @"', 
                '" + admin.Avatar + @"', 
                '" + admin.Email + @"', 
                '" + admin.Phone + @"'
                )";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DBConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }

        //PUT Method
        [HttpPut]
        public JsonResult Put(Admin admin)
        {
            string query = @"update dbo.Admin set
                        username = '" + admin.UserName + @"', " +
                        @"password  = '" + admin.Password + @"', " +
                        @"status = '" + admin.Status + @"', " +
                        @"fullname = '" + admin.Fullname + @"', " +
                        @"avatar = '" + admin.Avatar + @"', " +
                        @"email = '" + admin.Email + @"', " +
                        @"phone = '" + admin.Phone + @"' 
                        where admin_id = " + admin.AdminId + @"";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DBConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }

        //DELETE Method
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                        delete from dbo.Admin
                        where admin_id = " + id + @"";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DBConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }


        //private readonly ILogger<AdminController> _logger;

        //public AdminController(ILogger<AdminController> logger)
        //{
        //    _logger = logger;
        //}

        ////GET Admin
        //[HttpGet]
        //public IEnumerable<Admin> Get()
        //{
        //    //Querying with LINQ to Entities 
        //    var query = new List<Admin>();
        //    using (var context = new DBContext())
        //    {
        //        query = context.Admin.ToList();
        //    }
        //    return query;
        //}

    }
}
