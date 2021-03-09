using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("category_name")]
        public string CategoryName { get; set; }

        [Column("images")]
        public string Images { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("order_by")]
        public string OrderBy { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("update_date")]
        public DateTime UpdateDate { get; set; }

        //Liên kết với bảng con Product
        public virtual List<Product> Product { get; set; }

    }
}
