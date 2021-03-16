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
        public int ID { get; set; }

        [Required]
        public string SizeName { get; set; }

        //Liên kết với bảng con ProductDetail
        public virtual IEnumerable<ProductDetail> ProductDetail { get; set; }
    }
}
