using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Common
{
    internal class GraphHelper
    {
        public static void DisplayGraph(Graph graph)
        {
            foreach(var entry in graph.VertexAdjacencyNodes)
            {
                List<AdjacencyNode> nodes = entry.Value;
                foreach(AdjacencyNode node in nodes)
                {
                    Console.Write("Vertex: " + entry.Key + "-->" + node.Vertex + "|" + node.Weight + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
