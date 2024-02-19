using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Algorithms.Strings.LongestPalindromicSubstring
{
    internal static class Algorithm
    {
        internal static string LongestPalindromicSubstring(string str)
        {
            var maxLength = -1;
            var palindromeStartIndex = -1;
            if(str == null)
            {
                return str;
            }

            for (var i = 0; i < str.Length; i++)
            {
                var leftIndex = i-1;
                var rightIndex = i+1;
                while (leftIndex >=0 && rightIndex < str.Length)
                {
                    if (str[leftIndex] != str[rightIndex])
                    {
                        break;
                    }
                    leftIndex--;
                    rightIndex++;
                }

                var palindromeLength = rightIndex-1 - (leftIndex + 1) + 1;
                if (palindromeLength > maxLength)
                {
                    maxLength = palindromeLength;
                    palindromeStartIndex = leftIndex + 1;
                }

                // Check for Even Palindrome String
                leftIndex = i-1;
                rightIndex = i;
                while (leftIndex >= 0 && rightIndex < str.Length)
                {
                    if (str[leftIndex] != str[rightIndex])
                    {
                        break;
                    }
                    leftIndex--;
                    rightIndex++;
                }

                palindromeLength = rightIndex - 1 - (leftIndex + 1) + 1;
                if (palindromeLength > maxLength)
                {
                    palindromeStartIndex = leftIndex + 1;
                    maxLength = palindromeLength;
                }
            }

            var result = str.Substring(palindromeStartIndex,maxLength);
            return result;
        }
    }
}
