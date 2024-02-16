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
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public void TDelete(MessageCategory item)
        {
            _messageCategoryDal.Delete(item);
        }

        public MessageCategory TGetId(int id)
        {
            return _messageCategoryDal.GetId(id);
        }

        public List<MessageCategory> TGetList()
        {
            return _messageCategoryDal.GetList();
        }

        public void TInsert(MessageCategory item)
        {
            _messageCategoryDal.Insert(item);
        }

        public void TUpdate(MessageCategory item)
        {
            _messageCategoryDal.Update(item);
        }
    }
}
