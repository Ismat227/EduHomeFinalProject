﻿using EduHome.Models;
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
        public BlogCategoryViewModel BlogCategoryViewModel { get; set; }
        public BlogViewModel BlogViewModel { get; set; }
        public List<Blog> Blogs { get; set; }
        public Blog Blog { get; set; }
        public BlogCategory BlogCategory { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
        public BlogComment BlogComment { get; set; }
        public List<BlogComment> BlogComments { get; set; }
    }
}
