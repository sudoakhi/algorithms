using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Text;

namespace Algorithms.Arrays.LongestSubArrayWithSum
{
    public static class Algorithm
    {
        //Time Complexity O(N Square) Space Complexity O(1)
        public static int[ ] RunBruteForce(int[ ] array, int targetSum)
        {
            if(array != null)
            {
                int[] subArrayIndex = [];
                var subArrayLengthForTargetSum = 0;
                for(var i = 0; i < array.Length; i++)
                {
                    var j = i;
                    var sum = 0;
                    while(sum <= targetSum && j < array.Length)
                    {
                        sum += array[j];
                        if(sum == targetSum)
                        {
                            var length = j - i + 1;
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

            return null;
        }

        //Time Complexity O(N) Space Complexity O(1)
        public static int[ ] Run(int[ ] array, int targetSum)
        {
            if(array != null)
            {
                int[] subArrayIndex = [];
                var subArrayLengthForTargetSum = 0;
                var sum = 0;
                var startIndex = 0;
                var endIndex = 0;

                while(endIndex < array.Length)
                {
                    while(sum <= targetSum && endIndex < array.Length)
                    {
                        sum += array[endIndex];
                        if(sum == targetSum)
                        {
                            var length = endIndex - startIndex + 1;
                            if(subArrayLengthForTargetSum < length)
                            {
                                subArrayIndex = new int[2];
                                subArrayIndex[0] = startIndex;
                                subArrayIndex[1] = endIndex;
                                subArrayLengthForTargetSum = length;
                            }
                        }
                        endIndex++;
                    }

                    while(sum > targetSum && startIndex <= endIndex)
                    {
                        sum -= array[startIndex];
                        startIndex++;
                    }
                }

                return subArrayIndex;
            }

            return null;
        }
    }
}
