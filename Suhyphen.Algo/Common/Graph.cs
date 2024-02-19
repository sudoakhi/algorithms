using System;
using System.Collections.Generic;
using System.Text;
using Suhyphen.Algo.Common;

namespace Suhyphen.Algo.Common
{
    internal sealed class Graph
    {
        internal Dictionary<string, List<AdjacencyNode>> _vertexAdjacencyNodes = [];

        public Graph(List<Edge> edges)
        {
            foreach(var edge in edges)
            {
                if(_vertexAdjacencyNodes.TryGetValue(edge._sourceVertex , out var value) )
                {
                    var adjacencyNodes = value;
                    var adjacencyNode = new AdjacencyNode(edge._destinationVertex, edge._weight);
                    adjacencyNodes.Add(adjacencyNode);
                    _vertexAdjacencyNodes[edge._sourceVertex] = adjacencyNodes;
                }
                else
                {
                    var adjacencyNodes = new List<AdjacencyNode>();
                    var adjacencyNode = new AdjacencyNode(edge._destinationVertex, edge._weight);
                    adjacencyNodes.Add(adjacencyNode);
                    _vertexAdjacencyNodes.Add(edge._sourceVertex, adjacencyNodes);
                }
            }
        }
    }
}
