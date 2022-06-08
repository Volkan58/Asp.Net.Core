using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class ContactSubPlaceController : Controller
    {
        ContactManager contactmanager = new ContactManager(new EfContactDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = contactmanager.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contactmanager.TUpdate(contact);
            return RedirectToAction("Index", "Default");
        }
    }
}