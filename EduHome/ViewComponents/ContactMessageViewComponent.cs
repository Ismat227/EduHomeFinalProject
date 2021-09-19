using EduHome.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class ContactMessageViewComponent:ViewComponent
    {
        private EduHomeContext _context { get; }
        public ContactMessageViewComponent(EduHomeContext context)
        {
            _context = context;
        }
         public async Task<IViewComponentResult> InvokeAsync()
         {
            var model = await _context.contactMessages.FirstOrDefaultAsync();
            return View(await Task.FromResult(model));
         }
    }
}
