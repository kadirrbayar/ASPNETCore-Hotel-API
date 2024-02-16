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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public int TBookingCount()
        {
            return _bookingDal.BookingCount();
        }

        public void TDelete(Booking item)
        {
            _bookingDal.Delete(item);
        }

        public Booking TGetId(int id)
        {
            return _bookingDal.GetId(id);
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public void TInsert(Booking item)
        {
            _bookingDal.Insert(item);
        }

        public List<Booking> TLast6Booking()
        {
            return _bookingDal.Last6Booking();
        }

        public void TUpdate(Booking item)
        {
            _bookingDal.Update(item);
        }

        public void TUpdateBookingApprove(int id)
        {
            _bookingDal.UpdateBookingApprove(id);
        }

        public void TUpdateBookingDecline(int id)
        {
            _bookingDal.UpdateBookingDecline(id);
        }

        public void TUpdateBookingWaiting(int id)
        {
            _bookingDal.UpdateBookingWaiting(id);
        }
    }
}
