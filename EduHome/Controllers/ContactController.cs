using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class ContactController : Controller
    {
        private EduHomeContext _context { get; }
        public ContactController(EduHomeContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Page = "Contact";
            EduHomeViewModel eduhome = new EduHomeViewModel();
            eduhome.Settings = _context.Settings.FirstOrDefault();
            eduhome.socials = _context.socials.ToList();
            eduhome.contactAdresses = _context.contactAdresses.ToList();
            eduhome.contactMessages = _context.contactMessages.ToList();
            return View(eduhome);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Index(ContactMessageViewModel contactMessage)
        {
            if (!ModelState.IsValid) return View(contactMessage);
            ContactMessage message = new ContactMessage
            {
                Email = contactMessage.Email,
                Name = contactMessage.Name,
                Message = contactMessage.Message,
                Subject = contactMessage.Subject
            };
            await _context.contactMessages.AddAsync(message);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
            

        
    }
}
