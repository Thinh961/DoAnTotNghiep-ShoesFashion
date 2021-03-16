using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NCT_Fashion.Models.Entities
{
    [Table("News")]
    public class News
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string ShortContent { get; set; }

        [Required]
        public string MainContent { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string Image { get; set; }

        public int AdminId { get; set; }

        //Liên kết với bảng cha Admin
        [ForeignKey("AdminId")]
        public virtual Admin Admin { get; set; }
    }
}
