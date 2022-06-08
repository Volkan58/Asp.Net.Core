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
    [Authorize(Roles = "Admin")]
    public class FeatureController : Controller
    {
        FeatureManager featuremanager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
            
        {


            var values = featuremanager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature t)
        {
            featuremanager.TUpdate(t);
            return RedirectToAction ("Index", "Default");
        }
       
   
        }
        
    }

