using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Strings.LongestPalindromicSubstring
{
    internal static class Runner
    {
        public static void Run()
        {
            // This should return xyzzyx
            var inputString = "abaxyzzyxf";
            var outputString = Algorithm.LongestPalindromicSubstring(inputString);
            Console.WriteLine(outputString);
        }
    }
}
