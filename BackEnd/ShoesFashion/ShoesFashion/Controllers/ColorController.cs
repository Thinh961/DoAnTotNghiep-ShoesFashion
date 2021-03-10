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
    public class ColorController : ControllerBase
    {
        private readonly ILogger<ColorController> _logger;

        public ColorController(ILogger<ColorController> logger)
        {
            _logger = logger;
        }

        //GET Color
        [HttpGet]
        public IEnumerable<Color> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<Color>();
            using (var context = new DBContext())
            {
                query = context.Color.ToList();
            }
            return query;
        }
    }
}
