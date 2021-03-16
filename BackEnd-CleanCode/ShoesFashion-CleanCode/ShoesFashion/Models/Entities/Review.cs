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
        public int ID { get; set; }

        public int CustomerId { get; set; }

        public int ProductId { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string CustomerEmail { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public DateTime? UpdateDate { get; set; }

        //Liên kết với bảng cha Customer
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        //Liên kết với bảng cha Product
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
