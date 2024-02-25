using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Algorithms.LL
{
    public static class SingleLinkedListHelper
    {
        public static void InsertFront(SingleLinkedList singleLinkedList, int newData)
        {
            if(singleLinkedList == null)
            {
                return;
            }

            var newNode = new SingleLinkedListNode(newData)
            {
                Next = singleLinkedList.Head
            };
            singleLinkedList.Head = newNode;
        }

        public static void InsertLast(SingleLinkedList singleLinkedList, int newData)
        {
            if(singleLinkedList == null)
            {
                return;
            }

            var newNode = new SingleLinkedListNode(newData);
            var temp = singleLinkedList.Head;
            if(temp == null)
            {
                singleLinkedList.Head = newNode;
                return;
            }

            while(temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
        }

        public static void DeleteNodeByKey(SingleLinkedList singleLinkedList, int key)
        {
            if(singleLinkedList == null)
            {
                return;
            }

            var temp = singleLinkedList.Head;
            SingleLinkedListNode previousNode = null;

            if(temp != null && temp.Value == key)
            {
                singleLinkedList.Head = temp.Next;
                return;
            }

            while(temp != null && temp.Value != key)
            {
                previousNode = temp;
                temp = temp.Next;
            }

            previousNode.Next = temp.Next;
        }

        public static List<int> Traverse(SingleLinkedList singleLinkedList)
        {
            var values = new List<int>();
            if(singleLinkedList == null)
            {
                return null;
            }

            var temp = singleLinkedList.Head;
            while(temp != null)
            {
                values.Add(temp.Value);
                temp = temp.Next;
            }

            return values;
        }
    }
}
