using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Strings_CaesarCipherEncryptor
{
    internal class Runner
    {
        public static void Run()
        {
            //This should return zab
            string inputString = "xyz";
            int key = 2;
            string result = Algorithm.CaesarCypherEncryptor(inputString, key);
            Console.WriteLine(result);
        }
    }
}
