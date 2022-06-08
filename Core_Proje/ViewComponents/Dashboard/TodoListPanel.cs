using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class TodoListPanel:ViewComponent
    {
        TodoListManager todolistmanager = new TodoListManager(new EfTodoListDal());
        public IViewComponentResult Invoke()
        {
            var values = todolistmanager.TGetList();
            return View(values);
        }
    }
}
