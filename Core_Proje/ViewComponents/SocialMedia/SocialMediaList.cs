﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.SocialMedia
{
    public class SocialMediaList:ViewComponent
    {
        SocialMediaManager socialmediamanager = new SocialMediaManager(new EfSocialMediaDal());
        public IViewComponentResult Invoke()
        {
            var values = socialmediamanager.TGetList();

            return View(values);
        }
    }
}
