using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.LL.MiddleNode
{
    public sealed class Algorithm
    {
        public static SingleLinkedList MiddleNode(SingleLinkedList singleLinkedList)
        {
            if(singleLinkedList == null)
            {
                return null;
            }

            var head = singleLinkedList._head;
            if (head == null || head._next == null)
            {
                return singleLinkedList;
            }

            var slowNode = singleLinkedList._head;
            var fastNode = singleLinkedList._head;
            while (fastNode != null)
            {
                slowNode = slowNode._next;
                fastNode = fastNode._next._next;
            }

            var middle = new SingleLinkedList
            {
                _head = slowNode
            };
            return middle;
        }
    }
}
