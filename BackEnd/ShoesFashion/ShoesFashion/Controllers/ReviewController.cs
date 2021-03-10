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
    public class ReviewController : ControllerBase
    {
        private readonly ILogger<ReviewController> _logger;

        public ReviewController(ILogger<ReviewController> logger)
        {
            _logger = logger;
        }

        //GET Review
        [HttpGet]
        public IEnumerable<Review> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<Review>();
            using (var context = new DBContext())
            {
                query = context.Review.ToList();
            }
            return query;
        }
    }
}
