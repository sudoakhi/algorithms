using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs.CycleInGraph
{
    internal static class Algorithm
    {
        internal static bool CycleInGraph(Graph graph)
        {
            foreach(var entry in graph._vertexAdjacencyNodes)
            {
                var vertexStack = new Stack<string>();
                vertexStack.Push(entry.Key);
                while (vertexStack.Count > 0)
                {
					_ = vertexStack.Pop( );
					var nodes = entry.Value;
                    foreach (var node in nodes)
                    {
                        if(vertexStack.Contains(node._vertex))
                        {
                            return true;
                        } else
                        {
                            vertexStack.Push(node._vertex);
                        }
                    }
                }
            }
            
            return false;
        }
    }
}
