using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings.LongestPalindromicSubstring
{
    internal static class Runner
    {
        internal static void Run()
        {
            // This should return xyzzyx
            var inputString = "abaxyzzyxf";
            var outputString = Algorithm.LongestPalindromicSubstring(inputString);
            Console.WriteLine(outputString);
        }
    }
}
