using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Strings_LongestPalindromicSubstring
{
    internal class Runner
    {
        public static void Run()
        {
            // This should return xyzzyx
            string inputString = "abaxyzzyxf";
            string outputString = Algorithm.LongestPalindromicSubstring(inputString);
            Console.WriteLine(outputString);
        }
    }
}
