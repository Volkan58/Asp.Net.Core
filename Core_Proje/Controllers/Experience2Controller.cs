using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class Experience2Controller : Controller
    {
        ExpManager experiencemanager = new ExpManager(new EfExperienceDal());
        public IActionResult Index()
        {


            return View();
        }

        //Verilerin Ajax Kullanarak Listelenmesi
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experiencemanager.TGetList());

            return Json(values);

        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experiencemanager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

        public IActionResult GetByID(int ExperienceID)
        {
            var v = experiencemanager.TGetByID(ExperienceID);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }

        [HttpPost]
        public IActionResult DeleteExperience(int id)
        {
            var v = experiencemanager.TGetByID(id);
            experiencemanager.TDelete(v);
            return NoContent();

        }
        [HttpPost]
        public IActionResult UpdateExperince(Experience p)
        {
            var v = experiencemanager.TGetByID(p.ExperienceID);
            experiencemanager.TUpdate(v);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}

