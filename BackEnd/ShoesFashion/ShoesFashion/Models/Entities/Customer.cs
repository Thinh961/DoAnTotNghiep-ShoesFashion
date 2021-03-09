using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("fullname")]
        public string FullName { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("phone")]
        public string Phone { get; set; }
        [Column("status")]
        public int Status { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("birthday")]
        public DateTime Birthday { get; set; }
        [Column("image")]
        public string Image { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        //Liên kết với bảng con Order
        public virtual List<Order> Order { get; set; }

        //Liên kết với bảng con Review
        public virtual List<Review> Review { get; set; }
    }
}
