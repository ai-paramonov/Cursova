using System;
using System.Collections.Generic;
using System.Text;

namespace Cursova
{
    public class Checker
    {
        const string alfabet = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";

        public string ErrorText(string key)
        {
            if (key.Length == 0)
            {
                return "Key can`t be empty for Caesar or Vigenere method";
            }
            return "Invalid key, click 'Help' to read the requirements for key ";
        }
        public bool IsOnlyUkrainianLetters(string key)
        {
            string fullAlphabet = alfabet + alfabet.ToUpper();
            if(key == "")
            {
                return false;
            }
            for (int i = 0; i < key.Length; i++)
            {
                if (!fullAlphabet.Contains(key[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsOnlyIntegerKey(string textBox)
        {
            try
            {
                int key = Convert.ToInt32(textBox);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public bool IsKeyCaesarValueIsValid(string textBox)
        {
            if (IsOnlyIntegerKey(textBox) && Convert.ToInt32(textBox) >= 1 && Convert.ToInt32(textBox) <= alfabet.Length - 1)
            {
                return true;
            }
            return false;
        }

        public bool ChoosedFileIsCurrentlyExist(string filename)
        {
            try
            {
                System.IO.File.ReadAllText(filename);
                return true;
            }
            catch (System.IO.FileNotFoundException)
            {
                return false;
            }

        }
    }
}
