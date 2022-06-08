using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager pf = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
           
            var values=pf.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult PortfolioAdd()
        {
        

            return View();
        }

        [HttpPost]
        public IActionResult PortfolioAdd(Portfolio portfolio)
        {
            PortfolioValidator ptv = new PortfolioValidator();
            ValidationResult results = ptv.Validate(portfolio);
            if (results.IsValid)
            {
                pf.TAdd(portfolio);
                return RedirectToAction("Index");
            }

          else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);


                }
                return View();
            }



        }
        public IActionResult DeletePortfolio(int id)
        {
          
            var values = pf.TGetById(id);
            pf.TDelete(values);
            return RedirectToAction ("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
       
            var values = pf.TGetById(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator Validation = new PortfolioValidator();
            ValidationResult results = Validation.Validate(portfolio);

            if (results.IsValid)
            {
                pf.TUpdate(portfolio);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);


                }
                return View();
            }
           
        }


    }
}
