using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int ID { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int ProductQuantity { get; set; }

        public int Total { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string EmailShip { get; set; }

        //Liên kết với bảng cha Order
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        //Liên kết với bảng cha Product
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
