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
    public class OderDetailController : ControllerBase
    {
        private readonly ILogger<OderDetailController> _logger;

        public OderDetailController(ILogger<OderDetailController> logger)
        {
            _logger = logger;
        }

        //GET OrderDetail
        [HttpGet]
        public IEnumerable<OrderDetail> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<OrderDetail>();
            using (var context = new DBContext())
            {
                query = context.OrderDetail.ToList();
            }
            return query;
        }
    }
}
