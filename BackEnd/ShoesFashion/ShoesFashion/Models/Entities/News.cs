using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesFashion.Models.Entities
{
    [Table("News")]
    public class News
    {
        [Key]
        [Column("news_id")]
        public int NewsId { get; set; }

        [Column("short_content")]
        public string ShortContent { get; set; }

        [Column("main_content")]
        public string MainContent { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("update_date")]
        public DateTime updatedate { get; set; }

        [Column("image")]
        public string image { get; set; }

        [Column("admin_id")]
        public int AdminId { get; set; }

        //Liên kết với bảng cha Admin
        public virtual Admin Admin { get; set; }
    }
}
