﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings.CaesarCipherEncryptor
{
    internal static class Runner
    {
        internal static void Run()
        {
            //This should return zab
            var inputString = "xyz";
            var key = 2;
            var result = Algorithm.CaesarCypherEncryptor(inputString, key);
            Console.WriteLine(result);
        }
    }
}