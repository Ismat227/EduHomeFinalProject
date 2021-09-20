using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class BlogComment
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string Comment { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int UserId { get; set; }
        public AppUser User { get; set; }
    }
}
