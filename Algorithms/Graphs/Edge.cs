using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class Edge
    {
        public string SourceVertex { get; set; }
        public string DestinationVertex { get; set; }
        public int Weight { get; set; }

        public Edge(string sourceVertex, string destinationVertex, int weight)
        {
            SourceVertex = sourceVertex;
            DestinationVertex = destinationVertex;
            Weight = weight;
        }
    }
}
