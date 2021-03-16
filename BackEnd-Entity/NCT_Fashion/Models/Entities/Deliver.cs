using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NCT_Fashion.Models.Entities
{
    [Table("Deliver")]
    public class Deliver
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string DeliverName { get; set; }

        public int Status { get; set; }

        //Liên kết với bảng con Order
        public virtual IEnumerable<Order> Order { get; set; }
    }
}
