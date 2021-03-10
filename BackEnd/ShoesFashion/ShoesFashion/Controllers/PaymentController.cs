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
    public class PaymentController : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        //GET Payment
        [HttpGet]
        public IEnumerable<Payment> Get()
        {
            //Querying with LINQ to Entities 
            var query = new List<Payment>();
            using (var context = new DBContext())
            {
                query = context.Payment.ToList();
            }
            return query;
        }
    }
}
