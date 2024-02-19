using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trie.SuffixTrieConstruction
	{
    internal static class Runner
    {
        internal static void Run()
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
