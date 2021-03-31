using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NCT_Fashion.Models.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ID { get; set; }

        public int CategoryId { get; set; }

        public int SupplierId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Image { get; set; }

        //[NotMapped]
        //public IFormFile ImageFile { get; set; }

        public int Status { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string Description { get; set; }

        public string ShortName { get; set; }

        public DateTime? StartSale { get; set; }

        public DateTime? EndSale { get; set; }

        //Liên kết với bảng con ProductDetail
        public virtual IEnumerable<ProductDetail> Details { get; set; }

        //Liên kết với bảng con OrderDetail
        public virtual IEnumerable<OrderDetail> OrderDetail { get; set; }

        //Liên kết với bảng cha Category
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        //Liên kết với bảng cha Supplier
        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        //Liên kết với bảng con Review
        public virtual IEnumerable<Review> Review { get; set; }
    }
}
