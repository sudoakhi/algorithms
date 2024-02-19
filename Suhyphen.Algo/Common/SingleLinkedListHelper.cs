using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace suhyphen.Algo.Common
{
    internal class SingleLinkedListHelper
    {
        internal void InsertFront(SingleLinkedList singleLinkedList, int newData)
        {
            SingleLinkedListNode newNode = new SingleLinkedListNode(newData)
            {
                Next = singleLinkedList.Head
            };
            singleLinkedList.Head = newNode;
        }

        internal void InsertLast(SingleLinkedList singleLinkedList, int newData)
        {
            SingleLinkedListNode newNode = new SingleLinkedListNode(newData);
            SingleLinkedListNode temp = singleLinkedList.Head;
            if (temp == null)
            {
                singleLinkedList.Head = newNode;
                return;
            }

            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
        }

        internal void DeleteNodeByKey(SingleLinkedList singleLinkedList, int key)
        {
            SingleLinkedListNode temp = singleLinkedList.Head;
            SingleLinkedListNode previousNode = null;

            if (temp != null && temp.Value == key)
            {
                singleLinkedList.Head = temp.Next;
                return;
            }

            while (temp != null && temp.Value != key)
            {
                previousNode = temp;
                temp = temp.Next;
            }

            previousNode.Next = temp.Next;
        }

        internal void Traverse(SingleLinkedList singleLinkedList)
        {
            SingleLinkedListNode temp = singleLinkedList.Head;
            while (temp != null)
            {
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }

            Console.WriteLine();
        }
    }
}
