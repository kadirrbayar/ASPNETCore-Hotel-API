using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager:ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial item)
        {
            _testimonialDal.Delete(item);
        }

        public Testimonial TGetId(int id)
        {
            return _testimonialDal.GetId(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TInsert(Testimonial item)
        {
            _testimonialDal.Insert(item);
        }

        public void TUpdate(Testimonial item)
        {
            _testimonialDal.Update(item);
        }
    }
}
