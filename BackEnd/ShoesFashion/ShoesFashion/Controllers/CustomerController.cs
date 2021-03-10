using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoesFashion.DataManager;
using ShoesFashion.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        //GET Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<Customer>();
            using (var context = new DBContext())
            {
                query = context.Customer.ToList();
            }
            return query;
        }
    }
}
