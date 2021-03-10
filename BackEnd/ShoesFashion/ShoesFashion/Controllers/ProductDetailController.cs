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
    public class ProductDetailController : ControllerBase
    {
        private readonly ILogger<ProductDetailController> _logger;

        public ProductDetailController(ILogger<ProductDetailController> logger)
        {
            _logger = logger;
        }

        //GET ProductDetail
        [HttpGet]
        public IEnumerable<ProductDetail> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<ProductDetail>();
            using (var context = new DBContext())
            {
                query = context.ProductDetail.ToList();
            }
            return query;
        }
    }
}
