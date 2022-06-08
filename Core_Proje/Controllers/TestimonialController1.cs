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
    public class TestimonialController1 : Controller
    {
        TestimonialManager testimonialmanager = new TestimonialManager(new EfTestimonialDal());
        
        public IActionResult Index()
        {
            var values = testimonialmanager.TGetList();
            return View(values);
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var values = testimonialmanager.TGetByID(id);
            testimonialmanager.TDelete(values);
            return RedirectToAction("Index");


        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial p)
        {
            testimonialmanager.TAdd(p);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            var values = testimonialmanager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTestimonial(Testimonial p)
        {
            testimonialmanager.TUpdate(p);
           return RedirectToAction ("Index");
        }
    }
}
