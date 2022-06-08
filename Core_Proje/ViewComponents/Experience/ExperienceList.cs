using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent

    {
        ExpManager Em = new ExpManager(new EfExperienceDal());
       public IViewComponentResult Invoke()
        {
            var values=Em.TGetList();

            return View(values);
        }
        
    }
}
