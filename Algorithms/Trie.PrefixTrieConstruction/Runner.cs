using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trie.PrefixTrieConstruction
	{
    internal static class Runner
    {
        internal static void Run()
        {
            string[] strings = ["the", "a", "there", "answer",
                        "any", "by", "bye", "their"];

            var trie = new PrefixTrie();
            foreach(var s in strings)
            {
                Algorithm.Insert(trie, s);
            }

            //This should return true
            var isStringPresent = Algorithm.Search(trie, "there");
            Console.WriteLine(isStringPresent);

            //This should return false
            Algorithm.Delete(trie, "there");
            isStringPresent = Algorithm.Search(trie, "there");
            Console.WriteLine(isStringPresent);

            //This should return Algorithm
            isStringPresent = Algorithm.Search(trie, "bya");
            Console.WriteLine(isStringPresent);

            //This should return true
            isStringPresent = Algorithm.Search(trie, "by");
            Console.WriteLine(isStringPresent);

        }
    }
}
