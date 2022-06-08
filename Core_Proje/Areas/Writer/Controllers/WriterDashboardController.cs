using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area ("Writer")]

    public class WriterDashboardController : Controller
    {
        private readonly UserManager<WriterUser> _usermanager;

        public WriterDashboardController(UserManager<WriterUser> usermanager)
        {
            _usermanager = usermanager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + "" + values.SurName;
            //Weather Api
            //Api Key
            string api = "2d57ee84975640259a5eb13d3d9ef2ee";
            //Api Adres
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=%C4%B0stanbul&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

             //Statistics
            Context c = new Context();
            ViewBag.v1 = c.WriterMessages.Where(x=>x.Receiver==values.Email).Count();
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.Users.Count() ;
            ViewBag.v4 = c.Skills.Count();

            return View();
        }
    }
}

