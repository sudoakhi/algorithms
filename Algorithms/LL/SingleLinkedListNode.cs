using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LL
{
    public class SingleLinkedListNode
    {
        public int Value { get; set; }
        public SingleLinkedListNode Next { get; set; }

        public SingleLinkedListNode(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
