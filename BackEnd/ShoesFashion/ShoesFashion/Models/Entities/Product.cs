using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("supplier_id")]
        public int SupplierId { get; set; }

        [Column("product_name")]
        public string ProductName { get; set; }

        [Column("image_name")]
        public string ImageName { get; set; }

        [Column("status")]
        public int Status { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("update_date")]
        public DateTime UpdateDate { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("short_name")]
        public string ShortName { get; set; }

        [Column("start_sale")]
        public DateTime StartSale { get; set; }

        [Column("end_sale")]
        public DateTime EndSale { get; set; }

        //Liên kết với bảng con ProductDetail
        public virtual List<ProductDetail> Details { get; set; }

        //Liên kết với bảng con OrderDetail
        public virtual List<OrderDetail> OrderDetail { get; set; }

        //Liên kết với bảng cha Category
        public virtual Category Category { get; set; }

        //Liên kết với bảng cha Supplier
        public virtual Supplier Supplier { get; set; }

        //Liên kết với bảng con Review
        public virtual List<Review> Review { get; set; }
    }
}
