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
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        //GET Order
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<Order>();
            using (var context = new DBContext())
            {
                query = context.Order.ToList();
            }
            return query;
        }
    }
}
