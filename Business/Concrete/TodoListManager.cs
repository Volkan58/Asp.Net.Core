using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TodoListManager : ITodoListService
    {
        ITodoListDal _todolistdal;

        public TodoListManager(ITodoListDal todolistdal)
        {
            _todolistdal = todolistdal;
        }

        public void TAdd(TodoList t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(TodoList t)
        {
            throw new NotImplementedException();
        }

        public TodoList TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TodoList> TGetList()
        {
            return _todolistdal.GetList();
        }

        public void TUpdate(TodoList t)
        {
            throw new NotImplementedException();
        }
    }
}
