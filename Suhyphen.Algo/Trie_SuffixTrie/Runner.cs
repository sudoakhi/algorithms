using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Trie_SuffixTrie
{
    internal class Runner
    {
        public static void Run()
        {
            string inputString = "babc";
            SuffixTrie trie = new SuffixTrie();
            Algorithm.Insert(trie, inputString);

            //This should return true
            bool isStringPresent = Algorithm.Contains(trie, "abc");
            Console.WriteLine(isStringPresent);
        }
    }
}
