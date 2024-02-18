using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Trie_PrefixTrie
{
    internal class Runner
    {
        public static void Run()
        {
            string[] strings = {"the", "a", "there", "answer",
                        "any", "by", "bye", "their"};

            PrefixTrie trie = new PrefixTrie();
            foreach(string s in strings)
            {
                Algorithm.Insert(trie, s);
            }

            //This should return true
            bool isStringPresent = Algorithm.Search(trie, "there");
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
