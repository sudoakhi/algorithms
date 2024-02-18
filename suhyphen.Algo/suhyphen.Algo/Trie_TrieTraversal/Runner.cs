using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Trie_TrieTraversal
{
    internal class Runner
    {
        public static void Run()
        {
            string[] strings = {"the", "a", "there", "answer",
                        "any", "by", "bye", "their"};

            Trie trie = new Trie();
            foreach(string s in strings)
            {
                TrieHelper.Insert(trie, s);
            }

            //This should return true
            bool isStringPresent = TrieHelper.Search(trie, "there");
            Console.WriteLine(isStringPresent);

            //This should return false
            TrieHelper.Delete(trie, "there");
            isStringPresent = TrieHelper.Search(trie, "there");
            Console.WriteLine(isStringPresent);

            //This should return false
            isStringPresent = TrieHelper.Search(trie, "bya");
            Console.WriteLine(isStringPresent);

            //This should return true
            isStringPresent = TrieHelper.Search(trie, "by");
            Console.WriteLine(isStringPresent);

        }
    }
}
