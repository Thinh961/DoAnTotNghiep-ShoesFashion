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
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }

        //GET Category
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<Category>();
            using (var context = new DBContext())
            {
                query = context.Category.ToList();
            }
            return query;
        }
    }
}
