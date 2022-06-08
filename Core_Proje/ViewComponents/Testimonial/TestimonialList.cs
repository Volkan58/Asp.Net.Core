using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager testimonialmanager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var Values = testimonialmanager.TGetList();

            return View(Values);
        }
    }
}
