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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfoliodal;

        public PortfolioManager(IPortfolioDal portfoliodal)
        {
            _portfoliodal = portfoliodal;
        }

        public void TAdd(Portfolio t)
        {
            _portfoliodal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfoliodal.Delete(t);
        }

        public List<Portfolio> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public Portfolio TGetById(int id)
        {
            return _portfoliodal.GetById(id);
        }

        public Portfolio TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Portfolio> TGetList()
        {
            return _portfoliodal.GetList();
        }

        public List<Portfolio> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portfolio t)
        {
            _portfoliodal.Update(t);
        }
    }
}
