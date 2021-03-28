using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NCT_Fashion.Models.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int ID { get; set; }

        public int CustomerId { get; set; }

        //[Required]  
        public string UserName { get; set; }

        [Required]
        public string PhoneShip { get; set; }

        [Required]
        public string AddressShip { get; set; }

        public string Request { get; set; }

        public decimal Total { get; set; }

        public int PayId { get; set; }

        public int DeliverId { get; set; }

        public string EmailShip { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int AdminId { get; set; }

        public int Status { get; set; }

        //Liên kết với bảng cha Customer
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        //Liên kết với bảng cha Payment
        [ForeignKey("PayId")]
        public virtual Payment Payment { get; set; }

        //Liên kết với bảng cha Deliver
        [ForeignKey("DeliverId")]
        public virtual Deliver Deliver { get; set; }

        //Liên kết với bảng cha Admin
        [ForeignKey("AdminId")]
        public virtual Admin Admin { get; set; }

        //Liên kết với bảng con OrderDetail
        public virtual IEnumerable<OrderDetail> OrderDetail { get; set; }
    }
}
