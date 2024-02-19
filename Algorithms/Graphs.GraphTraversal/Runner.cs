using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs.GraphTraversal
{
    internal static class Runner
    {
        internal static void Run()
        {
            var edge1 = new Edge("1", "2", 0);
            var edge2 = new Edge("1", "8", 0);
            var edge3 = new Edge("1", "4", 0);
            var edge4 = new Edge("1", "9", 0);
            var edge5 = new Edge("2", "5", 0);
            var edge6 = new Edge("2", "7", 0);
            var edge7 = new Edge("3", "6", 0);
            var edge8 = new Edge("4", "11", 0);
            var edge9 = new Edge("5", "7", 0);
            var edge10 = new Edge("7", "2", 0);
            var edge11 = new Edge("9", "4", 0);
            var edge12 = new Edge("9", "10", 0);

            var edgeList = new List<Edge>
            {
                edge1,
                edge2,
                edge3,
                edge4,
                edge5,
                edge6,
                edge7,
                edge8,
                edge9,
                edge10,
                edge11,
                edge12,
            };

            var graph = new Graph(edgeList);
            GraphHelper.DisplayGraph(graph);
            Algorithm.DepthFirstTraversal(graph, "1");
            Algorithm.BreadthFirstTraversal(graph, "1");
        }
    }
}
