using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Common
{
    internal static class GraphHelper
    {
        internal static void DisplayGraph(Graph graph)
        {
            foreach(var entry in graph._vertexAdjacencyNodes)
            {
                var nodes = entry.Value;
                foreach(var node in nodes)
                {
                    Console.Write("Vertex: " + entry.Key + "-->" + node._vertex + "|" + node._weight + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
