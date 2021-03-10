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
    public class NewsController : ControllerBase
    {
        private readonly ILogger<NewsController> _logger;

        public NewsController(ILogger<NewsController> logger)
        {
            _logger = logger;
        }

        //GET News
        [HttpGet]
        public IEnumerable<News> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<News>();
            using (var context = new DBContext())
            {
                query = context.News.ToList();
            }
            return query;
        }
    }
}
