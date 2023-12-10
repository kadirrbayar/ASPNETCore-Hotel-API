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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TDelete(Service item)
        {
            _serviceDal.Delete(item);
        }

        public Service TGetId(int id)
        {
            return _serviceDal.GetId(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TInsert(Service item)
        {
            _serviceDal.Insert(item);
        }

        public void TUpdate(Service item)
        {
            _serviceDal.Update(item);
        }
    }
}
