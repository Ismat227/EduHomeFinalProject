using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class BlogController : Controller
    {
        private EduHomeContext _context { get; }
        public BlogController(EduHomeContext context)
        {
            _context = context;
        }
        public  IActionResult Index(int page=1)
        {
            EduHomeViewModel models = new EduHomeViewModel();
            models.Settings = _context.Settings.FirstOrDefault();
            models.socials = _context.socials.ToList();
            models.Blogs = _context.Blogs.Include("BlogCategory").OrderByDescending(b => b.Id).Take(3).ToList();

            BlogCategoryViewModel category = new BlogCategoryViewModel();
            category.Blogs = _context.Blogs.ToList();

            BlogViewModel blog = new BlogViewModel();
            blog.CurrentPage = page;

            models.BlogCategories = _context.BlogCategories.ToList();
            //models.BlogComments = _context.BlogComments.ToList();
            models.BlogViewModel = blog;
            models.BlogCategoryViewModel = category;
            return View(models);
        }
        public ActionResult BlogDetails(int id)
        {

            EduHomeViewModel models = new EduHomeViewModel();

            models.Blog = _context.Blogs.Find(id);
            models.Settings = _context.Settings.FirstOrDefault();
            models.socials = _context.socials.ToList();
            models.BlogCategories = _context.BlogCategories.ToList();
            //models.BlogComments = _context.BlogComments.ToList();
            models.Blogs = _context.Blogs.Include("BlogCategory").OrderByDescending(o => o.Id).Take(3).ToList();

            BlogCategoryViewModel blog = new BlogCategoryViewModel();

            models.BlogCategoryViewModel = blog;

            return View(models);
        }
        [HttpPost]
        public ActionResult Message(BlogCommentViewModel blog, int id)
        {          

            BlogComment BlogComment = new BlogComment();
            BlogComment.Comment = blog.Message;
            BlogComment.BlogId = id;

            _context.BlogComments.Add(BlogComment);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
