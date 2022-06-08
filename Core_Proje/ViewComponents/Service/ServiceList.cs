using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager servicemanager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values=servicemanager.TGetList();
            
            return View(values);
        }
        
    }
}
