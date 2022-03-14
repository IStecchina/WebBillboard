using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBillboard.Abstract;
using WebBillboard.Models;
using WebBillboard.Options;

namespace WebBillboard.Gateways
{
    public class MessageGateway : IMessageGateway
    {
        private readonly Dictionary<int, Message> fakeDB = new()
        {
            { 1, new("Hello world!", "AAAA AAAA AAAA AAAA", "Tizio Caio", DateTime.Now, DateTime.Now, 1)},
            { 2, new("Hello world 2!", "BBBB BBBB BBBB BBBB", "Tizio Caio", DateTime.Now, DateTime.Now, 2)},
            { 3, new("Hello world 3!", "CCCC CCCC CCCC CCCC", "Tizio Caio", DateTime.Now, DateTime.Now, 3)}
        };

        public IEnumerable<Message> GetMessages()
        {
            return fakeDB.Values;
        }
        public Message GetMessage(int id)
        {
            if (fakeDB.ContainsKey(id))
            {
                return fakeDB[id];
            } else
            {
                return new("ERROR!", "There is no message matching this id", "", null, null, id);
            }
        }

        public bool DeleteMessage(int id)
        {
            return fakeDB.Remove(id);
        }
    }
}
