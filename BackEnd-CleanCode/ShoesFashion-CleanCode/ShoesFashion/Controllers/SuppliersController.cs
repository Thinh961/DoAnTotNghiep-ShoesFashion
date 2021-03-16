using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ShoesFashion.Models.Entities;
using System.Data.SqlClient;
using System.Data;

namespace ShoesFashion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public SuppliersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //GET Method
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                    select * from Supplier";
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
            string query = "select * from Supplier where id = " + id + @"";
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
        public JsonResult Post(Supplier supplier)
        {
            string query = @"insert into Supplier(supplierName, Phone, Address, Status, CreateDate, UpdateDate) values 
                (
                '" + supplier.supplierName + @"',
                '" + supplier.Phone + @"', 
                '" + supplier.Address + @"', 
                '" + supplier.Status + @"', 
                '" + supplier.CreateDate + @"',
                '" + supplier.UpdateDate + @"'
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
        public JsonResult Put(Supplier supplier)
        {
            string query = @"update dbo.Supplier set
                        supplierName = '" + supplier.supplierName + @"', " +
                        @"Phone = '" + supplier.Phone + @"', " +
                        @"Address = '" + supplier.Address + @"', " +
                        @"Status = '" + supplier.Status + @"', " +
                        @"CreateDate = '" + supplier.CreateDate + @"', " +
                        @"UpdateDate = '" + supplier.UpdateDate + @"' 
                        where ID = " + supplier.ID + @"";

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
                        delete from dbo.Supplier
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
