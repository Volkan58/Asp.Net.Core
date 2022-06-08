using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IWriterMessageService:IGenericService<WriterMessage>
    {
        //Gönderici Ve Alıcısı olan Mesaj  Sadece WriterMessageye Ait olması için Oluşturulan metod.
        List<WriterMessage> GetListSenderMessage(string p);
        List<WriterMessage> GetListReceiverMessage(string p);


    }
}
