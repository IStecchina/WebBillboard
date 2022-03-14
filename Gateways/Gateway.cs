using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBillboard.Abstract;
using WebBillboard.Options;

namespace WebBillboard.Gateways
{
    public class Gateway : IGateway
    {
        private readonly AppOptions _options;
        public Gateway(IOptions<AppOptions> options)
        {
            _options = options.Value;
        }
        public IEnumerable<string> GetStudents()
        {
            return _options.Students;
        }
    }
}
