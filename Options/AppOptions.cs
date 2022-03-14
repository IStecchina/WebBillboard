using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBillboard.Options
{
    public class AppOptions
    {
        [Required]
        public IEnumerable<string> Students { get; set; } = null!;
    }
}
