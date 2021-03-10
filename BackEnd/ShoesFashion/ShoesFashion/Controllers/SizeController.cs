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
    public class SizeController : ControllerBase
    {
        private readonly ILogger<SizeController> _logger;

        public SizeController(ILogger<SizeController> logger)
        {
            _logger = logger;
        }

        //GET Size
        [HttpGet]
        public IEnumerable<Size> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<Size>();
            using (var context = new DBContext())
            {
                query = context.Size.ToList();
            }
            return query;
        }
    }
}
