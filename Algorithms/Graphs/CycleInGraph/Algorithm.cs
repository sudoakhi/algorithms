using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs.CycleInGraph
{
    public static class Algorithm
    {
        public static bool Run(Graph graph)
        {
            if (graph == null || graph.VertexAdjacencyNodes == null)
            {
                return false;
            }

            foreach (var entry in graph.VertexAdjacencyNodes)
            {
                var vertexStack = new Stack<string>();
                vertexStack.Push(entry.Key);
                while(vertexStack.Count > 0)
                {
                    _ = vertexStack.Pop( );
                    var nodes = entry.Value;
                    foreach(var node in nodes)
                    {
                        if(vertexStack.Contains(node.Vertex))
                        {
                            return true;
                        }
                        else
                        {
                            vertexStack.Push(node.Vertex);
                        }
                    }
                }
            }

            return false;
        }
    }
}
