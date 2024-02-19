using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Common
{
    internal class Edge
    {
        internal string SourceVertex;
        internal string DestinationVertex;
        internal int Weight;

        public Edge(string sourceVertex, string destinationVertex, int weight)
        {
            SourceVertex = sourceVertex;
            DestinationVertex = destinationVertex;
            Weight = weight;
        }
    }
}
