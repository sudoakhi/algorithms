using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Graph_CycleInGraph
{
    internal class Algorithm
    {
        public static bool CycleInGraph(Graph graph)
        {
            foreach(var entry in graph.VertexAdjacencyNodes)
            {
                Stack<string> vertexStack = new Stack<string>();
                vertexStack.Push(entry.Key);
                while (vertexStack.Count > 0)
                {
                    string currentVertex = vertexStack.Pop();
                    List<AdjacencyNode> nodes = entry.Value;
                    foreach (AdjacencyNode node in nodes)
                    {
                        if(vertexStack.Contains(node.Vertex))
                        {
                            return true;
                        } else
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
