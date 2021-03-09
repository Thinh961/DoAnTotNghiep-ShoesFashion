using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("Color")]
    public class Color
    {
        [Column("color_id")]
        public int ColorId { get; set; }

        [Column("color_name")]
        public string ColorName { get; set; }

        //Liên kết với bảng con ProductDetail
        public virtual List<ProductDetail> ProductDetail { get; set; }

    }
}
