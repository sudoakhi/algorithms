using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.LongestPeak
{
    internal class Runner
    {
        public static void Run()
        {
            // This should return 6
            int[] array1 = { 1,2,3,3,4,0,10,6,5,-1,-3,2,3 };
            int peakLength = Algorithm.FindLongestPeak(array1);
            Console.WriteLine("Peak Length: " + peakLength);

            // This should return 0
            int[] array2 = { 1, 2, 3};
            peakLength = Algorithm.FindLongestPeak(array2);
            Console.WriteLine("Peak Length: " + peakLength);

            // This should return 4
            int[] array3 = { 1, 4, 10, 2 };
            peakLength = Algorithm.FindLongestPeak(array3);
            Console.WriteLine("Peak Length: " + peakLength);

            // This should return 0
            int[] array4 = { 4, 0, 10 };
            peakLength = Algorithm.FindLongestPeak(array4);
            Console.WriteLine("Peak Length: " + peakLength);

            // This should return 0
            int[] array5 = { 1, 2, 2, 0 };
            peakLength = Algorithm.FindLongestPeak(array5);
            Console.WriteLine("Peak Length: " + peakLength);
        }
    }
}
