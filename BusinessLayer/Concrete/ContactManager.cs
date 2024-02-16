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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TDelete(Contact item)
        {
            _contactDal.Delete(item);
        }

        public Contact TGetId(int id)
        {
            return _contactDal.GetId(id);
        }

        public List<Contact> TGetList()
        {
           return _contactDal.GetList();
        }

        public int TInboxCount()
        {
            return _contactDal.InboxCount();
        }

        public void TInsert(Contact item)
        {
            _contactDal.Insert(item);
        }

        public int TSendBoxCount()
        {
            return _contactDal.SendBoxCount();
        }

        public void TUpdate(Contact item)
        {
            _contactDal.Update(item);
        }
    }
}
