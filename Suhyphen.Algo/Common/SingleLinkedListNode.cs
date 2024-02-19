using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Common
{
    internal class SingleLinkedListNode
    {
        internal int Value;
        internal SingleLinkedListNode Next;

        public SingleLinkedListNode(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
