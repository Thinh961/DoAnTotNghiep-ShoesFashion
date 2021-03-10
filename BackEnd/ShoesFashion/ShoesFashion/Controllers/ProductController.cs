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
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        //GET Product
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<Product>();
            using (var context = new DBContext())
            {
               query = context.Product.ToList();  
            }
            return query;
        }
        

    }
}
