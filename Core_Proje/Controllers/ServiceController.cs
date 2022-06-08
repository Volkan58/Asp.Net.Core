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
    public class ServiceController : Controller
    {
        ServiceManager servicemanager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            var values = servicemanager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult ServiceAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ServiceAdd(Service service)
        {
            servicemanager.TAdd(service);
            return RedirectToAction("Index");
            
        }

        public IActionResult DeleteService(int id)
        {
           var values= servicemanager.TGetById(id);
            servicemanager.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            var values = servicemanager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            servicemanager.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
