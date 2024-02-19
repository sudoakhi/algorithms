using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Algorithms.Strings.CaesarCipherEncryptor
{
    internal static class Algorithm
    {
        internal static string CaesarCypherEncryptor(string str, int key)
        {
            if (str != null)
            {
                var newStringLetters = new char[str.Length];
                var newKey = key % 26;
                var alphabet = "abcdefghijklmnopqrstuvwxyz";
                for ( var i = 0; i < str.Length; i++ )
                {
                    newStringLetters[i] = GetNewLetter(str[i] , newKey , alphabet);
                }

                return new string(newStringLetters);
            }

            return null;
        }

        internal static char GetNewLetter(char letter, int key, string alphabet)
        {
            if ( alphabet != null )
            {
                var newLetterCode = alphabet.IndexOf(letter, System.StringComparison.Ordinal) + key;
                return alphabet[newLetterCode % 26];
            }

            return letter;
        }
    }
}
