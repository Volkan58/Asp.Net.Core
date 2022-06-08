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
   public class WriterMessageManager:IWriterMessageService
    {
        IWriterMessageDal _writermessageDal;

        public WriterMessageManager(IWriterMessageDal writermessagedal)
        {
            _writermessageDal = writermessagedal;
        }
        //Alıcı ve gönderici mesajları
        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writermessageDal.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writermessageDal.GetByFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
            _writermessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _writermessageDal.Delete(t);
        }

        public List<WriterMessage> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetByID(int id)
        {
            return _writermessageDal.GetById(id);
        }

        public List<WriterMessage> TGetList()
        {
            return _writermessageDal.GetList();
        }

 

        public List<WriterMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
