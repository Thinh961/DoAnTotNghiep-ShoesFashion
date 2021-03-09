using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("Deliver")]
    public class Deliver
    {
        [Key]
        [Column("deliver_id")]
        public int DeliverId { get; set; }

        [Column("deliver_name")]
        public string DeliverName { get; set; }

        [Column("status")]
        public int Status { get; set; }

        //Liên kết với bảng con Order
        public virtual List<Order> Order { get; set; }
    }
}
