using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class Graph
    {
        public Dictionary<string, List<AdjacencyNode>> VertexAdjacencyNodes { get; }

        public Graph(List<Edge> edges)
        {
            if(edges == null || edges.Count == 0)
            {
                VertexAdjacencyNodes = null;
            }
            else
            {
                VertexAdjacencyNodes = [ ];
                foreach(var edge in edges)
                {
                    if(VertexAdjacencyNodes.TryGetValue(edge.SourceVertex, out var value))
                    {
                        var adjacencyNodes = value;
                        var adjacencyNode = new AdjacencyNode(edge.DestinationVertex, edge.Weight);
                        adjacencyNodes.Add(adjacencyNode);
                        VertexAdjacencyNodes[edge.SourceVertex] = adjacencyNodes;
                    }
                    else
                    {
                        var adjacencyNodes = new List<AdjacencyNode>();
                        var adjacencyNode = new AdjacencyNode(edge.DestinationVertex, edge.Weight);
                        adjacencyNodes.Add(adjacencyNode);
                        VertexAdjacencyNodes.Add(edge.SourceVertex, adjacencyNodes);
                    }
                }
            }
        }
    }
}
