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
    public class WriterUserController : Controller
    {
        WriterUserManager wusermanager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()
        {


            return View();
        }

        //Verilerin Ajax Kullanarak Listelenmesi
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(wusermanager.TGetList());

            return Json(values);

        }

    [HttpPost]
    public IActionResult AddUser(WriterUser p)
        {
            wusermanager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}
