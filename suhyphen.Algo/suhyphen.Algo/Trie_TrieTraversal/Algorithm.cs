using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Trie_TrieTraversal
{
    internal class Algorithm
    {
        public static void Traverse(Trie trie)
        {
            TrieNode rootNode = trie.Root;
            if(rootNode.IsLeaf())
            {
                Console.WriteLine("Trie is empty");
                return;
            }

            Queue<TrieNode> queue = new Queue<TrieNode>();
            TrieNode currentNode = rootNode;
            queue.Enqueue(currentNode);
            while (queue.Count > 0)
            {
                TrieNode node = queue.Dequeue();
                Console.WriteLine(node.Depth + " -- " + node.Value);
                List<TrieNode> children = node.Children;
                if(children.Count > 0 )
                {
                    foreach (TrieNode child in children)
                    {
                        queue.Enqueue(child);
                    }
                }   
            }
        }
    }
}
