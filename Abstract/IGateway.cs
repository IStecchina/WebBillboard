using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBillboard.Abstract
{
    public interface IGateway
    {
        IEnumerable<string> GetStudents();
    }
}
