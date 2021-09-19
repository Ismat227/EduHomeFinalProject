using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class ContactAdress
    {
        public int Id { get; set; }
        [StringLength(150)]        
        public string Image { get; set; }
        [Required,StringLength(50)]
        public string Country { get; set; }
        [Required, StringLength(50)]
        public string Street { get; set; }
        [StringLength(50)]
        public string  Name { get; set; }
    }
}
