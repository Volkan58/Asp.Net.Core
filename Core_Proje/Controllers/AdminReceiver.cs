using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
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
    public class AdminReceiver : Controller
    {
        string p;
        WriterMessageManager writermessagemanager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {

            p = "admin@gmail.com";
            var values = writermessagemanager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {

            p = "admin@gmail.com";
            var values = writermessagemanager.GetListSenderMessage(p);
            return View(values);
        }

        [HttpGet]
        public IActionResult AdminMessageDetails(int id)
        {
            var values = writermessagemanager.TGetByID(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult AdminMessageDelete(int id)
        {

      
        
            var values = writermessagemanager.TGetByID(id);
            writermessagemanager.TDelete(values);

            return RedirectToAction("ReceiverMessageList");

        }
        [HttpGet]
        public IActionResult AddMessageSend()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            //Mesaj Alıcı ismi işlemi

            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + "" + y.SurName).FirstOrDefault();
            p.ReceiverName = usernamesurname;

            writermessagemanager.TAdd(p);

            return RedirectToAction("SenderMessageList");
        }



    }
}
