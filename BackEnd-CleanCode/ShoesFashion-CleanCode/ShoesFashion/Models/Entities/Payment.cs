using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string PayName { get; set; }

        public int Status { get; set; }
        //Liên kết với bảng con Order
        public virtual IEnumerable<Order> Order { get; set; }
    }
}
