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
    public class SupplierController : ControllerBase
    {
        private readonly ILogger<SupplierController> _logger;

        public SupplierController(ILogger<SupplierController> logger)
        {
            _logger = logger;
        }

        //GET Supplier
        [HttpGet]
        public IEnumerable<Supplier> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<Supplier>();
            using (var context = new DBContext())
            {
                query = context.Supplier.ToList();
            }
            return query;
        }
    }
}
