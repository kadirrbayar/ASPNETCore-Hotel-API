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
    public class EfDbUserDal : GenericRepository<DbUser>, IDbUserDal
    {
        public EfDbUserDal(Context context) : base(context)
        {

        }

        public int DbUserCount()
        {
            using(var context = new Context())
            {
                return context.Users.Count();
            }
        }
    }
}
