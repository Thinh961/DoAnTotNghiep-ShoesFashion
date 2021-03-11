using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("Admin")]
    public class Admin
    {

        [Key]
        public int ID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public int Status { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Avatar { get; set; }


        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        //Liên kết với bảng con News
        //public virtual List<News> News { get; set; }
        public virtual IEnumerable<News> News { get; set; }

        //Liên kết với bảng con Order
        //public virtual List<Order> Order { get; set; }
        public virtual IEnumerable<Order> Order { get; set; }
    }
}
