using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace suhyphen.Algo.Strings_CaesarCipherEncryptor
{
    internal class Algorithm
    {
        public static string CaesarCypherEncryptor(string str, int key)
        {
            char[] newStringLetters = new char[str.Length];
            int newKey = key % 26;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for(int i=0; i<str.Length; i++)
            {
                newStringLetters[i] = getNewLetter(str[i], newKey, alphabet);
            }

            return new string(newStringLetters);
        }

        public static char getNewLetter(char letter, int key, string alphabet)
        {
            int newLetterCode = alphabet.IndexOf(letter) + key;
            return alphabet[newLetterCode%26];
        }
    }
}
