using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("Review")]
    public class Review
    {
        [Key]
        [Column("review_id")]
        public int ReviewId { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("content")]
        public string Content { get; set; }

        [Column("customer_mail")]
        public string CustomerEmail { get; set; }

        [Column("customer_name")]
        public string CustomerName { get; set; }

        [Column("update_date")]
        public DateTime UpdateDate { get; set; }

        //Liên kết với bảng cha Customer
        public virtual Customer Customer { get; set; }

        //Liên kết với bảng cha Product
        public virtual Product Product { get; set; }
    }
}
