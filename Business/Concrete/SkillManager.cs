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
    public class SkillManager : ISkillService
    {
        ISkillDal _skilldal;

        public SkillManager()
        {
        }

        public SkillManager(ISkillDal skilldal)
        {
            _skilldal = skilldal;
        }

        public void TAdd(Skill t)
        {
            _skilldal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skilldal.Delete(t);
        }

        public List<Skill> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public Skill TGetById(int id)
        {
           return _skilldal.GetById(id);
        }

        public Skill TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Skill> TGetList()
        {
            return _skilldal.GetList();
        }

        public List<Skill> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
           _skilldal.Update(t);
        }
    }
}
