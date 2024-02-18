using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Trie_SuffixTrieMultiStringSearch
{
    internal class Runner
    {
        public static void Run()
        {
            SuffixTrie trie = new SuffixTrie();
            string bigString = "abcdefghijklmnopqrstuvwxyz";
            if(bigString.Contains(" "))
            {
                string[] inputStringArray = bigString.Split(" ");
                foreach(string s in inputStringArray)
                {
                    Algorithm.Insert(trie, s);
                }
            }
            else
            {
                Algorithm.Insert(trie, bigString);
            }


            string[] smallerString = { "abc", "mnopqr", "wyz", "no", "e", "tuuv" };
            bool[] resultArray = new bool[smallerString.Length];

            for(int i= 0; i < smallerString.Length; i++)
            {
                if(Algorithm.Contains(trie, smallerString[i]))
                {
                    resultArray[i] = true;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", resultArray));
        }
    }
}
