using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.ViewComponents
{
    public class Navbar:ViewComponent
    {
        private readonly UserManager<WriterUser> _usermanager;

        public Navbar(UserManager<WriterUser> usermanager)
        {
            _usermanager = usermanager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.ImageUrl;
            return View();
        }
    }
}
