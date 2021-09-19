using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Socials
    {
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Icon { get; set; }
        [Required,StringLength(50)]
        public string Links { get; set; }
    }
}
