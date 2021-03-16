using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NCT_Fashion.Models.Entities
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public string Images { get; set; }


        public string Description { get; set; }

        public string OrderBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        //Liên kết với bảng con Product
        public virtual IEnumerable<Product> Product { get; set; }

    }
}
