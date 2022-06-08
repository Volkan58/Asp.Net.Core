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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialmediadal;

        public SocialMediaManager(ISocialMediaDal socialmediadal)
        {
            _socialmediadal = socialmediadal;
        }

        public void TAdd(SocialMedia t)
        {
            _socialmediadal.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialmediadal.Delete(t);
        }

        public List<SocialMedia> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialmediadal.GetById(id);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialmediadal.GetList();
        }

        public List<SocialMedia> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SocialMedia t)
        {
            _socialmediadal.Update(t);
        }
    }
}
