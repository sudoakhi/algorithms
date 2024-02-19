using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Common
{
    internal sealed class AdjacencyNode
    {
        internal string _vertex;
        internal int _weight;

        public AdjacencyNode(string vertex, int weight)
        {
            _vertex = vertex;
            _weight = weight;
        }
    }
}
