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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TDelete(About item)
        {
            _aboutDal.Delete(item);
        }

        public About TGetId(int id)
        {
            return _aboutDal.GetId(id);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TInsert(About item)
        {
            _aboutDal.Insert(item);
        }

        public void TUpdate(About item)
        {
            _aboutDal.Update(item);
        }
    }
}
