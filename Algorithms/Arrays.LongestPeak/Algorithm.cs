using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace Algorithms.Arrays.LongestPeak
{
    internal static class Algorithm
    {
        internal static int FindLongestPeak(int[] array)
        {
            var maxPeakLength = 0;
            for (var i = 1; i < array.Length-1; i++)
            {
                if ((array[i] > array[i-1]) && (array[i] > array[i+1]))
                {
                    var leftCounter = i;
                    var rightCounter = i;
                    while (leftCounter - 1 >= 0 && (array[leftCounter - 1] < array[leftCounter]))
                    {
                        leftCounter--;
                    }

                    while (rightCounter + 1 < array.Length && (array[rightCounter + 1] < array[rightCounter]))
                    {
                        rightCounter++;
                    }

                    var peakLength = rightCounter - leftCounter + 1;

                    if(maxPeakLength < peakLength)
                    {
                        maxPeakLength = peakLength;
                    }

                    i = rightCounter;
                }
            }

            return maxPeakLength;
        }
    }
}
