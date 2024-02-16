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
    public class DbUserManager : IDbUserService
    {
        private readonly IDbUserDal _dbUserDal;
        public DbUserManager(IDbUserDal dbUserDal)
        {
            _dbUserDal = dbUserDal;
        }

        public int TDbUserCount()
        {
            return _dbUserDal.DbUserCount();
        }

        public void TDelete(DbUser item)
        {
            _dbUserDal.Delete(item);
        }

        public DbUser TGetId(int id)
        {
            return _dbUserDal.GetId(id);
        }

        public List<DbUser> TGetList()
        {
            return _dbUserDal.GetList();
        }

        public void TInsert(DbUser item)
        {
            _dbUserDal.Insert(item);
        }

        public void TUpdate(DbUser item)
        {
            _dbUserDal.Update(item);
        }
    }
}
