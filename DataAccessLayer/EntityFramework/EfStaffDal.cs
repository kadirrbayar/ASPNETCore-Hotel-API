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
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base (context)
        {
            
        }

        public List<Staff> Last4Staff()
        {
            var context = new Context();
            var values = context.Staffs.OrderByDescending(x => x.Id).Take(4).ToList();
            return values;
        }

        public int StaffCount()
        {
            using(var db = new Context())
            {
                var values = db.Staffs.Count();
                return values;
            }
        }
    }
}
