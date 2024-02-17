using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Text;

namespace suhyphen.Algo.Arrays_LongestSubArrayWithSum
{
    internal class Algorithm
    {
        //Time Complexity O(N Square) Space Complexity O(1)
        public static int[] FindLongestSubArrayWithSumBruteForce(int[] array, int targetSum)
        {
            int[] subArrayIndex = { };
            int subArrayLengthForTargetSum = 0;
            for (int i=0; i < array.Length; i++) 
            {
                int j = i;
                int sum = 0;
                while (sum <= targetSum && j < array.Length)
                {
                    sum += array[j];
                    if(sum == targetSum)
                    {
                        int length = j - i + 1;
                        if(subArrayLengthForTargetSum < length)
                        {
                            subArrayIndex = new int[2];
                            subArrayIndex[0] = i;
                            subArrayIndex[1] = j;
                            subArrayLengthForTargetSum = length;
                        }
                    }

                    j++;
                }
            }

            return subArrayIndex;
        }


        //Time Complexity O(N) Space Complexity O(1)
        public static int[] FindLongestSubArrayWithSum(int[] array, int targetSum)
        {
            int[] subArrayIndex = { };
            int subArrayLengthForTargetSum = 0;
            int sum = 0;
            int startIndex = 0;
            int endIndex = 0;

            while (endIndex < array.Length)
            {
                while (sum <= targetSum && endIndex < array.Length)
                {
                    sum += array[endIndex];
                    if (sum == targetSum)
                    {
                        int length = endIndex - startIndex + 1;
                        if (subArrayLengthForTargetSum < length)
                        {
                            subArrayIndex = new int[2];
                            subArrayIndex[0] = startIndex;
                            subArrayIndex[1] = endIndex;
                            subArrayLengthForTargetSum = length;
                        }
                    }
                    endIndex++;
                }

                while (sum > targetSum && startIndex <= endIndex)
                {
                    sum -= array[startIndex];
                    startIndex++;
                }
            }

            return subArrayIndex;

        }
    }
}
