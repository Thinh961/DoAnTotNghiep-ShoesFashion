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
    public class DeliverController : ControllerBase
    {
        private readonly ILogger<DeliverController> _logger;

        public DeliverController(ILogger<DeliverController> logger)
        {
            _logger = logger;
        }

        //GET Deliver
        [HttpGet]
        public IEnumerable<Deliver> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<Deliver>();
            using (var context = new DBContext())
            {
                query = context.Deliver.ToList();
            }
            return query;
        }
    }
}
