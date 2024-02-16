using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

        public int BookingCount()
        {
            using (var context = new Context())
            {
                var values = context.Bookings.Count();
                return values;
            }
        }

        public List<Booking> Last6Booking()
        {
            var context = new Context();
            var values = context.Bookings.OrderByDescending(x => x.Id).ToList();
            return values;
        }

        public void UpdateBookingApprove(int id)
        {
            using (var db = new Context())
            {
                var values = db.Bookings?.Where(x => x.Id == id).FirstOrDefault();
                if (values != null)
                    values.Status = "Onaylandı";
                db.SaveChanges();
            }
        }

        public void UpdateBookingDecline(int id)
        {
            using (var db = new Context())
            {
                var values = db.Bookings?.Where(x => x.Id == id).FirstOrDefault();
                if (values != null)
                    values.Status = "İptal Edildi";
                db.SaveChanges();
            }
        }

        public void UpdateBookingWaiting(int id)
        {
            using (var db = new Context())
            {
                var values = db.Bookings?.Where(x => x.Id == id).FirstOrDefault();
                if (values != null)
                    values.Status = "Bekleniyor";
                db.SaveChanges();
            }
        }
    }
}
