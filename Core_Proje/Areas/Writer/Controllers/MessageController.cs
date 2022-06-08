using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area ("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager writermessagemanager = new WriterMessageManager(new EfWriterMessageDal());
        private readonly UserManager<WriterUser> _usermanager;

        public MessageController(UserManager<WriterUser> usermanager)
        {
            _usermanager = usermanager;
        }
        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writermessagemanager.GetListReceiverMessage(p);
            return View(messageList);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writermessagemanager.GetListSenderMessage(p);
            return View(messageList);
        }

        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writermessage = writermessagemanager.TGetByID(id);
            return View(writermessage);
        }

        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMessage writermessage = writermessagemanager.TGetByID(id);
            return View(writermessage);
        }

        [HttpGet]
        [Route("")]
        [Route("SendMessage")]

        public IActionResult SendMsg()
        {
            return View();
        }

        [HttpPost]
        [HttpGet]
        [Route("")]
        [Route("SendMsg")]
        public async Task<IActionResult> SendMsg(WriterMessage p)
        {

            var values = await _usermanager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + "" + values.SurName;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + "" + y.SurName).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            writermessagemanager.TAdd(p);
            return RedirectToAction("SendMsg");

        }
    }
}
