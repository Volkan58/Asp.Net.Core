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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialdal;

        public TestimonialManager(ITestimonialDal testimonialdal)
        {
            _testimonialdal = testimonialdal;
        }

        public void TAdd(Testimonial t)
        {
            _testimonialdal.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonialdal.Delete(t);
        }

        public List<Testimonial> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialdal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialdal.GetList();
        }

        public List<Testimonial> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialdal.Update(t);
        }
    }
}
