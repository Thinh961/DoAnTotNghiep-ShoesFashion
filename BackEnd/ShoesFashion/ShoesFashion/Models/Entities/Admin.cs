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
        [Column("admin_id")]
        public int AdminId { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("status")]
        public int Status { get; set; }

        [Column("fullname")]
        public string Fullname { get; set; }

        [Column("avatar")]
        public string Avatar { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        //Liên kết với bảng con News
        public virtual List<News> News { get; set; }

        //Liên kết với bảng con Order
        public virtual List<Order> Order { get; set; }
    }
}
