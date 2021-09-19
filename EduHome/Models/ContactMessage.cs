using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Name { get; set; }
        [Required,StringLength(100)]
        public string Email { get; set; }
        [Required,StringLength(50)]
        public string Subject { get; set; }
        [Required,StringLength(255)]
        public string Message { get; set; }
    }
}
