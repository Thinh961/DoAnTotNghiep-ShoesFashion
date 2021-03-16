using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ShoesFashion.Models.Entities;
using System.Data.SqlClient;
using System.Data;

namespace ShoesFashion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public CustomerController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //GET Method
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                    select * from Customer";
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
            string query = "select * from Customer where id = " + id + @"";
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
        public JsonResult Post(Customer customer)
        {
            string query = @"insert into Customer(FullName, Username, Password, CreateDate , Address, Phone, 
                                                    Status, Email, Birthday, Image, Gender) values 
                (
                '" + customer.FullName + @"', 
                '" + customer.Username + @"', 
                '" + customer.Password + @"', 
                '" + customer.CreateDate + @"', 
                '" + customer.Address + @"',
                '" + customer.Phone + @"', 
                '" + customer.Status + @"', 
                '" + customer.Email + @"', 
                '" + customer.Birthday + @"', 
                '" + customer.Image + @"',
                '" + customer.Gender + @"'
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
        public JsonResult Put(Customer customer)
        {
            string query = @"update dbo.Customer set
                        FullName = '" + customer.FullName + @"', " +
                        @"Username  = '" + customer.Username + @"', " +
                        @"Password = '" + customer.Password + @"', " +
                        @"CreateDate = '" + customer.CreateDate + @"', " +
                        @"Address = '" + customer.Address + @"', " +
                        @"Phone  = '" + customer.Phone + @"', " +
                        @"Status = '" + customer.Status + @"', " +
                        @"Email = '" + customer.Email + @"', " +
                        @"Birthday = '" + customer.Birthday + @"', " +
                        @"Image = '" + customer.Image + @"', " +
                        @"Gender = '" + customer.Gender + @"' 
                        where ID = " + customer.ID + @"";

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
                        delete from dbo.Customer
                        where id = " + id + @"";

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
    }
}
