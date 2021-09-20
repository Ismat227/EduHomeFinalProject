using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class BlogViewModel
    {
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
