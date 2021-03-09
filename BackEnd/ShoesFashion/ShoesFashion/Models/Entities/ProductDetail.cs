using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("ProductDetail")]
    public class ProductDetail
    {
        [Key]
        [Column("productdetail_id")]
        public int ProductDetailId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("size_id")]
        public int SizeId { get; set; }

        [Column("color_id")]
        public int ColorId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("price_old")]
        public string PriceOld { get; set; }

        [Column("price_new")]
        public string PriceNew { get; set; }

        [Column("image_name")]
        public string ImageName { get; set; }

        //Liên kết với bảng cha Product
        public virtual Product Product { get; set; }

        //Liên kết với bảng cha Size
        public virtual Size Size { get; set; }

        //Liên kết với bảng cha Color
        public virtual Color Color { get; set; }
    }
}
