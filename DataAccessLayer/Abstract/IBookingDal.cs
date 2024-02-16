using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void UpdateBookingApprove(int id);
        void UpdateBookingDecline(int id);
        void UpdateBookingWaiting(int id);
        int BookingCount();
        List<Booking> Last6Booking(); 
    }
}
