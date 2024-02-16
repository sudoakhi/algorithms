using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace suhyphen.Algo.LongestPeak
{
    internal class Algorithm
    {
        internal static int FindLongestPeak(int[] array)
        {
            int maxPeakLength = 0;
            for (int i = 1; i < array.Length-1; i++)
            {
                if ((array[i] > array[i-1]) && (array[i] > array[i+1]))
                {
                    int leftCounter = i;
                    int rightCounter = i;
                    while (leftCounter - 1 >= 0 && (array[leftCounter - 1] < array[leftCounter]))
                    {
                        leftCounter--;
                    }

                    while (rightCounter + 1 < array.Length && (array[rightCounter + 1] < array[rightCounter]))
                    {
                        rightCounter++;
                    }

                    int peakLength = rightCounter - leftCounter + 1;

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
