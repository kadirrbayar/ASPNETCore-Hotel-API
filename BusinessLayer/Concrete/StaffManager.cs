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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void TDelete(Staff item)
        {
            _staffDal.Delete(item);
        }

        public Staff TGetId(int id)
        {
            return _staffDal.GetId(id);
        }

        public List<Staff> TGetList()
        {
            return _staffDal.GetList();
        }

        public void TInsert(Staff item)
        {
            _staffDal.Insert(item);
        }

        public void TUpdate(Staff item)
        {
            _staffDal.Update(item);
        }
    }
}
