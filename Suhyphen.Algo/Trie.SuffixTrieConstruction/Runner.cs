using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Trie.SuffixTrieConstruction
	{
    internal static class Runner
    {
        public static void Run()
        {
            var inputString = "babc";
            var trie = new SuffixTrie();
            Algorithm.Insert(trie, inputString);

            //This should return true
            var isStringPresent = Algorithm.Contains(trie, "abc");
            Console.WriteLine(isStringPresent);
        }
    }
}
