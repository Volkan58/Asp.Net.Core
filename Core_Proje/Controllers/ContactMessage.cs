using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactMessage : Controller
    {
        MessageManager messagemanager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messagemanager.TGetList();

            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var values = messagemanager.TGetByID(id);
            messagemanager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ContactDetails(int id)
        {
            var values = messagemanager.TGetByID(id);
            return View(values);
        }



    }
}
