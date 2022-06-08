using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
   [Authorize(Roles ="Admin")]
    public class ExperienceController : Controller
    {
       
        ExpManager Exp = new ExpManager(new EfExperienceDal());
        public IActionResult Index()
        {
       
            var values=Exp.TGetList();
            return View(values);
        }
        [HttpGet]

        public IActionResult ExpAdd()
        {

            return View();
        }


        [HttpPost]

        public IActionResult ExpAdd(Experience p)
        {
            Exp.TAdd(p);
            return RedirectToAction("Index");
            
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = Exp.TGetById(id);
            Exp.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
         

            var values = Exp.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience ep)
        {
            Exp.TUpdate(ep);
            return RedirectToAction("Index");

        }
    }
}
