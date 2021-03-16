using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NCT_Fashion.Models.Entities
{
    [Table("ProductDetail")]
    public class ProductDetail
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int SizeId { get; set; }

        public int ColorId { get; set; }

        public int ProductId { get; set; }

        public int PriceOld { get; set; }

        [Required]
        public int PriceNew { get; set; }

        public string Image { get; set; }

        //Liên kết với bảng cha Product
        public virtual Product Product { get; set; }

        //Liên kết với bảng cha Size
        [ForeignKey("SizeId")]
        public virtual Size Size { get; set; }

        //Liên kết với bảng cha Color
        [ForeignKey("ColorId")]
        public virtual Color Color { get; set; }
    }
}
