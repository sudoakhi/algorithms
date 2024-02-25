// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LL.FindLoop
{
    public static class Algorithm
    {
        public static SingleLinkedListNode Run(SingleLinkedListNode head)
        {
            if(head == null)
            {
                return null;
            }

            var first = head.Next;
            var second = head.Next.Next;
            while(first != second)
            {
                first = first.Next; 
                second = second.Next.Next;
            }

            first = head;
            while(first != second)
            {
                first = first.Next;
                second = second.Next;
            }

            return first;
        }
    }
}
