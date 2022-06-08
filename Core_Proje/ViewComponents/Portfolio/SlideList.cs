﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class SlideList:ViewComponent
    {
        PortfolioManager portfoliomanager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfoliomanager.TGetList();
            return View(values);
        }
    }
}