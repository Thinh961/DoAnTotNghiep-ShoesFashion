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
        [Column("orderdetail_id")]
        public int OrderDetailId { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("product_quantity")]
        public int ProductQuantity { get; set; }

        [Column("total")]
        public int Total { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("update_date")]
        public DateTime UpdateDate { get; set; }

        [Column("email_ship")]
        public int EmailShip { get; set; }

        //Liên kết với bảng cha Order
        public virtual Order Order { get; set; }

        //Liên kết với bảng cha Product
        public virtual Product Product { get; set; }
    }
}
