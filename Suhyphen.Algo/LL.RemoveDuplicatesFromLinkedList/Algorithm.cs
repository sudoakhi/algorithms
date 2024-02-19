using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Suhyphen.Algo.LL.RemoveDuplicatesFromLinkedList
{
    public sealed class Algorithm
    {
        public static SingleLinkedList RemoveDuplicatesFromLinkedList(SingleLinkedList singleLinkedList)
        {
			if (singleLinkedList == null)
			{
				return null;
			}
            var currentNode = singleLinkedList._head;
            while (currentNode != null)
            {
                var nextNode = currentNode._next;
                while (nextNode != null && nextNode._value == currentNode._value)
                {
                    nextNode = nextNode._next;
                }
                currentNode._next = nextNode;
                currentNode = nextNode;
            }

            return singleLinkedList;
        }
    }
}
