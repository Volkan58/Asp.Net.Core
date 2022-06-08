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
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialmediamanager = new SocialMediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {
            var values = socialmediamanager.TGetList();
            return View(values);
        }

        [HttpGet]

        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddSocialMedia(SocialMedia p)
        {
            p.Status = true;
            socialmediamanager.TAdd(p);
            return RedirectToAction ("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var values = socialmediamanager.TGetByID(id);
            socialmediamanager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult EditSocialMedia(int id)
        {
            var values = socialmediamanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]

        public IActionResult EditSocialMedia(SocialMedia p)
        {
            socialmediamanager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
