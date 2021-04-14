using System;
using System.Collections.Generic;
using System.Text;

namespace Cursova.Services.Abstract
{
    public interface IRequestService
    {
        public string GetDecryptAtbushMessage();
        public string GetDecryptCaesarMessage();
        public string GetDecryptVigenereMessage();
        public string GetEncryptAtbushMessage();
        public string GetEncryptCaesarMessage();
        public string GetEncryptVigenereMessage();
    }
}
