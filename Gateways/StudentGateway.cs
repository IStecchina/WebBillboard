using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBillboard.Abstract;
using WebBillboard.Options;

namespace WebBillboard.Gateways
{
    public class StudentGateway : IStudentGateway
    {
        private readonly ILogger<StudentGateway> _logger;
        private readonly AppOptions _options;
        public StudentGateway(IOptions<AppOptions> options, ILogger<StudentGateway> logger)
        {
            _logger = logger;
            _options = options.Value;
        }
        public IEnumerable<string> GetStudents()
        {
            return _options.Students;
        }
    }
}
