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
        public int ID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime? CreateDate { get; set; }

        public string Address { get; set; }

        [Required]
        public string Phone { get; set; }
        public int Status { get; set; }

        public string Email { get; set; }

        public DateTime? Birthday { get; set; }
        public string Image { get; set; }

        public string Gender { get; set; }

        //Liên kết với bảng con Order
        public virtual IEnumerable<Order> Order { get; set; }

        //Liên kết với bảng con Review
        public virtual IEnumerable<Review> Review { get; set; }
    }
}
