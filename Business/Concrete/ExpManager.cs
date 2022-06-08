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
   public class ExpManager : IExperienceService
    {
        IExperienceDal _experiencedal;

        public ExpManager(IExperienceDal experiencedal)
        {
            _experiencedal = experiencedal;
        }

        public void TAdd(Experience t)
        {
            _experiencedal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experiencedal.Delete(t);
        }

        public List<Experience> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public Experience TGetById(int id)
        {
            return _experiencedal.GetById(id);
        }

        public Experience TGetByID(int id)
        {
            return _experiencedal.GetById(id);
        }

        public List<Experience> TGetList()
        {
            return _experiencedal.GetList();
        }

        public List<Experience> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Experience t)
        {
            _experiencedal.Update(t);
        }
    }
}
