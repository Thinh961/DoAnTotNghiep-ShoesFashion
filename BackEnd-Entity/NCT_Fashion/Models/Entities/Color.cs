using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NCT_Fashion.Models.Entities
{
    [Table("Color")]
    public class Color
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string ColorName { get; set; }

        //Liên kết với bảng con ProductDetail
        public virtual IEnumerable<ProductDetail> ProductDetail { get; set; }

    }
}
