using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trie.SuffixTrieMultiStringSearch
{
    internal static class Runner
    {
        public static void Run()
        {
            var trie = new SuffixTrie();
            var bigString = "abcdefghijklmnopqrstuvwxyz";
            if(bigString.Contains(' ', StringComparison.Ordinal))
            {
                var inputStringArray = bigString.Split(" ");
                foreach(var s in inputStringArray)
                {
                    Algorithm.Insert(trie, s);
                }
            }
            else
            {
                Algorithm.Insert(trie, bigString);
            }

            string[] smallerString = ["abc", "mnopqr", "wyz", "no", "e", "tuuv"];
            var resultArray = new bool[smallerString.Length];

            for(var i= 0; i < smallerString.Length; i++)
            {
                if(Algorithm.Contains(trie, smallerString[i]))
                {
                    resultArray[i] = true;
                }
            }

            Console.WriteLine(string.Join(", ", resultArray));
        }
    }
}
