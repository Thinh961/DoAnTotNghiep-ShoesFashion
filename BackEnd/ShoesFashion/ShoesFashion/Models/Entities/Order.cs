using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        [Column("phone_ship")]
        public string PhoneShip { get; set; }

        [Column("address_ship")]
        public string AddressShip { get; set; }

        [Column("request")]
        public string Request { get; set; }

        [Column("total")]
        public int Total { get; set; }

        [Column("pay_id")]
        public int PayId { get; set; }

        [Column("deliver_id")]
        public int DeliverId { get; set; }

        [Column("email_ship")]
        public string EmailShip { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("update_date")]
        public DateTime UpdateDate { get; set; }
        [Column("admin_id")]
        public int AdminId { get; set; }

        [Column("status")]
        public int Status { get; set; }

        //Liên kết với bảng cha Customer
        public virtual Customer Customer { get; set; }

        //Liên kết với bảng cha Payment
        public virtual Payment Payment { get; set; }

        //Liên kết với bảng cha Deliver
        public virtual Deliver Deliver { get; set; }

        //Liên kết với bảng cha Admin
        public virtual Admin Admin { get; set; }

        //Liên kết với bảng con OrderDetail
        public virtual List<OrderDetail> OrderDetail { get; set; }
    }
}
