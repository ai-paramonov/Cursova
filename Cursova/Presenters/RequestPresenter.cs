using System;
using System.Collections.Generic;
using System.Text;
using Cursova.Views;
using Cursova.Enums;
using Cursova.Services;

namespace Cursova.Presenters
{
    public class RequestPresenter
    {
        IRequest requestView;
        RequestService requestService = new RequestService();

        public RequestPresenter(IRequest view)
        {
            requestView = view;
        }
        public void ReadMessageFromFile(string fileName)
        {
            requestService.ReadMessageFromFile(fileName);
        }
        public void GetOperationFromUI(Operations operation)
        {
            requestView.Operation = operation;
            requestService.GetOperationFromPresenter(operation);
        }
        public void GetMethodFromUI(Method method)
        {
            requestView.Method = method;
            requestService.GetMethodFromPresenter(method);
        }
        public void GetCaesarKeyFromUI(int key)
        {
            requestView.KeyCaesar = key;
            requestService.GetCaesarKeyFromPresenter(key);
        }
        public void GetVigenereKeyFromUI(string key)
        {
            requestView.KeyVigenere = key;
            requestService.GetVigenereKeyFromPresenter(key);
        }
        public string RunCipherMachine()
        {
            return GetResult();
        }
        private string GetResult()
        {
            if (requestView.Operation == Operations.Encrypt)
            {
                if (requestView.Method == Method.Caesar)
                {
                    return requestService.GetEncryptCaesarMessage();
                }
                else if (requestView.Method == Method.Vigenere)
                {
                    return requestService.GetEncryptVigenereMessage();
                }
                return requestService.GetEncryptAtbushMessage();
            }
            else
            {
                if (requestView.Method == Method.Caesar)
                {
                    return requestService.GetDecryptCaesarMessage();
                }
                else if (requestView.Method == Method.Vigenere)
                {
                    return requestService.GetDecryptVigenereMessage();
                }
                return requestService.GetDecryptAtbushMessage();
            }
        }
    }
}
