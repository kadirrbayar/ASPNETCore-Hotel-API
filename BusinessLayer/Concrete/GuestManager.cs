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
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void TDelete(Guest item)
        {
            _guestDal.Delete(item);
        }

        public Guest TGetId(int id)
        {
            return _guestDal.GetId(id);
        }

        public List<Guest> TGetList()
        {
            return _guestDal.GetList();
        }

        public void TInsert(Guest item)
        {
            _guestDal.Insert(item);
        }

        public void TUpdate(Guest item)
        {
            _guestDal.Update(item);
        }
    }
}
