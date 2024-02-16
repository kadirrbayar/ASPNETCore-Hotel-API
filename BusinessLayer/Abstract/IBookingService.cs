using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void TUpdateBookingApprove(int id);
        void TUpdateBookingDecline(int id);
        void TUpdateBookingWaiting(int id);
        int TBookingCount();
        List<Booking> TLast6Booking();
    }
}
