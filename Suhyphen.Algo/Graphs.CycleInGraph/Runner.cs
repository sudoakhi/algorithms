using Suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suhyphen.Algo.Graphs.CycleInGraph
{
    internal static class Runner
    {
        public static void Run()
        {
            var edge1 = new Edge("0", "1", 0);
            var edge2 = new Edge("0", "3", 0);
            var edge3 = new Edge("1", "2", 0);
            var edge4 = new Edge("1", "3", 0);
            var edge5 = new Edge("1", "4", 0);
            var edge6 = new Edge("2", "0", 0);
            var edge7 = new Edge("3", "null", 0);
            var edge8 = new Edge("4", "2", 0);
            var edge9 = new Edge("4", "5", 0);
            var edge10 = new Edge("5", "null", 0);

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
                edge10
            };

            var graph = new Graph(edgeList);
            //This should return true
            var isCycle = Algorithm.CycleInGraph(graph);
            Console.WriteLine(isCycle);
        }
    }
}
