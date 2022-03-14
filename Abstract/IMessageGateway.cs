using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBillboard.Models;

namespace WebBillboard.Abstract
{
    public interface IMessageGateway
    {
        IEnumerable<Message> GetMessages();
        Message GetMessage(int id);
        bool DeleteMessage(int id);
    }
}
