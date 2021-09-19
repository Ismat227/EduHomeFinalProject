using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class EduHomeViewModel
    {
        public Settings Settings { get; set; }
        public List<Socials> socials { get; set; }
        public List<ContactAdress> contactAdresses { get; set; }
        public List<ContactMessage> contactMessages { get; set; }
    }
}
