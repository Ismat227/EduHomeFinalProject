using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Settings
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Logo { get; set; } 
        [StringLength(255)]
        public string FooterLogo { get; set; }
        [Required,StringLength(150)]
        public string Addres { get; set; }
        [Required,StringLength(50)]
        public string HeaderPhone { get; set; }
        [Required,StringLength(50)]
        public string FooterNumberOne { get; set; } 
        [Required,StringLength(50)]
        public string FooterNumberTwo{ get; set; }
        [Required,StringLength(50)]
        public string SiteName { get; set; }
        [Required,StringLength(50)]
        public string Copyright { get; set; }

    }
}
