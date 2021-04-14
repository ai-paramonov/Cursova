using Cursova.Enums;
using Cursova.Models;
using Cursova.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cursova.Services
{
    public class RequestService : IRequestService
    {
        public readonly Request request = new Request();
        public void ReadMessageFromFile(string fileName)
        {
            request.Message =  System.IO.File.ReadAllText(fileName);
        }
        public void GetOperationFromPresenter(Operations operation)
        {
            request.Operation = operation;
        }
        public void GetMethodFromPresenter(Method method)
        {
            request.Method = method;
        }
        public void GetCaesarKeyFromPresenter(int key)
        {
            request.CaesarKey = key;
        }
        public void GetVigenereKeyFromPresenter(string key)
        {
            request.VigenereKey = key;
        }
        public string GetDecryptAtbushMessage()
        {
            return EncryptDecrypt(request.Message, Reverse(alfabet), alfabet);
        }

        public string GetDecryptCaesarMessage()
        {
            return CaesarCodeEncode(request.Message, -request.CaesarKey);
        }

        public string GetDecryptVigenereMessage()
        {
            return Vigenere(request.Message, request.VigenereKey, false);
        }

        public string GetEncryptAtbushMessage()
        {
            return EncryptDecrypt(request.Message, alfabet, Reverse(alfabet));
        }

        public string GetEncryptCaesarMessage()
        {
            return CaesarCodeEncode(request.Message, request.CaesarKey);
        }

        public string GetEncryptVigenereMessage()
        {
            return Vigenere(request.Message, request.VigenereKey);
        }

        const string alfabet = " абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";

        private string CaesarCodeEncode(string text, int k)
        {
            //додаємо великі літери
            var fullAlfabet = alfabet + alfabet.ToUpper();
            fullAlfabet = fullAlfabet.Replace(" ", "");
            var letterQty = fullAlfabet.Length;
            var retVal = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    //Якщо символ не знайдено,то додаємо незмінюючи
                    retVal += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index + k) % letterQty;
                    retVal += fullAlfabet[codeIndex];
                }
            }
            return retVal;
        }


        private string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }

            return p.Substring(0, n);
        }

        private string Vigenere(string text, string password, bool encrypting = true)
        {
            var gamma = GetRepeatKey(password, text.Length);
            var retValue = "";
            var q = alfabet.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = alfabet.IndexOf(text[i]);
                var codeIndex = alfabet.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    //Якщо символ не знайдено,то додаємо незмінюючи
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += alfabet[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }

            return retValue;
        }

        private string Reverse(string inputText)
        {
            //Тут зберігаюмо результат
            var reversedText = string.Empty;
            foreach (var s in inputText)
            {
                //додаюмо на початок символ
                reversedText = s + reversedText;
            }

            return reversedText;
        }

        //метод шифровання/дешифрування
        private string EncryptDecrypt(string text, string symbols, string cipher)
        {
            //переводим текст в нижній регістр
            text = text.ToLower();

            var outputText = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                //пошук позиції символа в алфавіті
                var index = symbols.IndexOf(text[i]);
                if (index >= 0)
                {
                    //замінв символу на шифр
                    outputText += cipher[index].ToString();
                }
            }

            return outputText;
        }
    }
}
