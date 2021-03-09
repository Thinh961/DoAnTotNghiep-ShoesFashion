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
        [Column("pay_id")]
        public int PayId { get; set; }

        [Column("pay_name")]
        public string PayName { get; set; }

        [Column("status")]
        public int Status { get; set; }
        //Liên kết với bảng con Order
        public virtual List<Order> Order { get; set; }
    }
}
