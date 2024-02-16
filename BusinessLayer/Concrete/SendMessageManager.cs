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
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void TDelete(SendMessage item)
        {
            _sendMessageDal.Delete(item);
        }

        public SendMessage TGetId(int id)
        {
            return _sendMessageDal.GetId(id);
        }

        public List<SendMessage> TGetList()
        {
            return _sendMessageDal.GetList();
        }

        public void TInsert(SendMessage item)
        {
            _sendMessageDal.Insert(item);
        }

        public void TUpdate(SendMessage item)
        {
            _sendMessageDal.Update(item);
        }
    }
}
