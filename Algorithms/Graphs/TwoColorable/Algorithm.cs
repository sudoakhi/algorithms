// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graphs.TwoColorable
{
    public static class Algorithm
    {
        public static bool Run(int[][] edges)
        {
            if(edges == null)
            {
                return false;
            }

            var colors = new int[edges.Length];
            colors[0] = 0;
            var stack = new Stack<int>();
            stack.Push(0);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                foreach(var connection in edges[node])
                {
                    if (colors[connection] == 0)
                    {
                        colors[connection] = colors[node] == 1 ? 2 : 1;
                        stack.Push(connection);
                    } else if (colors[connection] == colors[node]) 
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
