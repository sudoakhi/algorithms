using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Common
{
    internal class AdjacencyNode
    {
        internal string Vertex;
        internal int Weight;

        public AdjacencyNode(string vertex, int weight)
        {
            Vertex = vertex;
            Weight = weight;
        }
    }
}
