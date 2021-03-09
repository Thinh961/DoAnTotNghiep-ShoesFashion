using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("Size")]
    public class Size
    {
        [Key]
        [Column("size_id")]
        public int SizeId { get; set; }

        [Column("size_name")]
        public string SizeName { get; set; }

        //Liên kết với bảng con ProductDetail
        public virtual List<ProductDetail> ProductDetail { get; set; }
    }
}
