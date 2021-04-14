using System;
using System.Collections.Generic;
using System.Text;

namespace Cursova.Views
{
    public interface IRequest
    {
        public string FileName { get; set; }
        public Enums.Operations Operation { get; set; }
        public Enums.Method Method { get; set; }
        public string KeyVigenere { get; set; }
        public int KeyCaesar { get; set; }
    }
}
