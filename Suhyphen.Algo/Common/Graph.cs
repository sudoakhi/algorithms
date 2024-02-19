using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Common
{
    internal class Graph
    {
        internal Dictionary<string, List<AdjacencyNode>> VertexAdjacencyNodes = new Dictionary<string, List<AdjacencyNode>>();

        public Graph(List<Edge> edges)
        {
            foreach(Edge edge in edges)
            {
                if(VertexAdjacencyNodes.ContainsKey(edge.SourceVertex))
                {
                    List<AdjacencyNode> adjacencyNodes = VertexAdjacencyNodes[edge.SourceVertex];
                    AdjacencyNode adjacencyNode = new AdjacencyNode(edge.DestinationVertex, edge.Weight);
                    adjacencyNodes.Add(adjacencyNode);
                    VertexAdjacencyNodes[edge.SourceVertex] = adjacencyNodes;
                }
                else
                {
                    List<AdjacencyNode> adjacencyNodes = new List<AdjacencyNode>();
                    AdjacencyNode adjacencyNode = new AdjacencyNode(edge.DestinationVertex, edge.Weight);
                    adjacencyNodes.Add(adjacencyNode);
                    VertexAdjacencyNodes.Add(edge.SourceVertex, adjacencyNodes);
                }
            }
        }
    }
}
