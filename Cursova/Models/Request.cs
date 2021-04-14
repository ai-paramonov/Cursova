using System;
using System.Collections.Generic;
using System.Text;

namespace Cursova.Models
{
    public class Request
    {
        public string FileName { get; set; }
        public string Message { get; set; }
        public Enums.Operations Operation { get; set; }
        public Enums.Method Method { get; set; }
        public int CaesarKey { get; set; }
        public string VigenereKey { get; set; }

    }
}
