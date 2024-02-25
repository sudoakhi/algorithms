using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public class AdjacencyNode
    {
        public string Vertex { get; set; }
        public int Weight { get; set; }

        public AdjacencyNode(string vertex, int weight)
        {
            Vertex = vertex;
            Weight = weight;
        }
    }
}
