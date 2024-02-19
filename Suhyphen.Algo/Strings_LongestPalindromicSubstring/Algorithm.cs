using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace suhyphen.Algo.Strings_LongestPalindromicSubstring
{
    internal class Algorithm
    {
        public static string LongestPalindromicSubstring(string str)
        {
            int maxLength = -1;
            int palindromeStartIndex = -1;
            for (int i = 0; i < str.Length; i++)
            {
                int leftIndex = i-1;
                int rightIndex = i+1;
                while (leftIndex >=0 && rightIndex < str.Length)
                {
                    if (str[leftIndex] != str[rightIndex]) { break; }
                    leftIndex--;
                    rightIndex++;
                }
                
                int palindromeLength = (rightIndex-1) - (leftIndex + 1) + 1;
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
                    if (str[leftIndex] != str[rightIndex]) { break; }
                    leftIndex--;
                    rightIndex++;
                }

                palindromeLength = (rightIndex - 1) - (leftIndex + 1) + 1;
                if (palindromeLength > maxLength)
                {
                    palindromeStartIndex = leftIndex + 1;
                    maxLength = palindromeLength;
                }

            }
            
            string result = str.Substring(palindromeStartIndex,maxLength);
            return result;
        }
    }
}
