using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Image { get; set; }
        [Required]
        public string Content { get; set; }
        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }
        public BlogComment BlogComment { get; set; }
    }
}
