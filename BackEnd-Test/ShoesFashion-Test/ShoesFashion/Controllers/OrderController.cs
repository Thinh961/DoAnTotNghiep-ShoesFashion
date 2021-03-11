using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ShoesFashion.Models.Entities;
using System.Data.SqlClient;
using System.Data;

namespace ShoesFashion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public OrderController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //GET Method
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                    select * from Orders";
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
            string query = "select * from Orders where id = " + id + @"";
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
        public JsonResult Post(Order orders)
        {
            string query = @"insert into Orders(CustomerId, UserName, PhoneShip, 
                                    AddressShip , Request, Total, PayId, DeliverId, 
                                        EmailShip, CreateDate, UpdateDate, AdminId, Status) values 
                (
                '" + orders.CustomerId + @"',
                '" + orders.UserName + @"', 
                '" + orders.PhoneShip + @"', 
                '" + orders.AddressShip + @"', 
                '" + orders.Request + @"', 
                '" + orders.Total + @"',
                '" + orders.PayId + @"',
                '" + orders.DeliverId + @"', 
                '" + orders.EmailShip + @"', 
                '" + orders.CreateDate + @"', 
                '" + orders.UpdateDate + @"', 
                '" + orders.AdminId + @"',
                '" + orders.Status + @"'
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
        public JsonResult Put(Order orders)
        {
            string query = @"update dbo.Orders set
                        CustomerId = '" + orders.CustomerId + @"', " +
                        @"UserName  = '" + orders.UserName + @"', " +
                        @"PhoneShip = '" + orders.PhoneShip + @"', " +
                        @"AddressShip = '" + orders.AddressShip + @"', " +
                        @"Request = '" + orders.Request + @"', " +
                        @"Total = '" + orders.Total + @"', " +
                        @"PayId  = '" + orders.PayId + @"', " +
                        @"DeliverId = '" + orders.DeliverId + @"', " +
                        @"EmailShip = '" + orders.EmailShip + @"', " +
                        @"CreateDate = '" + orders.CreateDate + @"', " +
                        @"UpdateDate = '" + orders.UpdateDate + @"', " +
                        @"AdminId = '" + orders.AdminId + @"', " +
                        @"Status = '" + orders.Status + @"' 
                        where ID = " + orders.ID + @"";

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
                        delete from dbo.Orders
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
