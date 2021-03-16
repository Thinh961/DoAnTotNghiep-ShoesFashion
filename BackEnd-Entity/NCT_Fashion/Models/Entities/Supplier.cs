using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NCT_Fashion.Models.Entities
{
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        public int ID { get; set; }

        public string supplierName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public int Status { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        //Liên kết với bảng con Product
        public virtual IEnumerable<Product> Product { get; set; }
    }
}
