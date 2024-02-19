using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Graph_CycleInGraph
{
    internal class Runner
    {
        public static void Run()
        {
            Edge edge1 = new Edge("0", "1", 0);
            Edge edge2 = new Edge("0", "3", 0);
            Edge edge3 = new Edge("1", "2", 0);
            Edge edge4 = new Edge("1", "3", 0);
            Edge edge5 = new Edge("1", "4", 0);
            Edge edge6 = new Edge("2", "0", 0);
            Edge edge7 = new Edge("3", "null", 0);
            Edge edge8 = new Edge("4", "2", 0);
            Edge edge9 = new Edge("4", "5", 0);
            Edge edge10 = new Edge("5", "null", 0);

            List<Edge> edgeList = new List<Edge>
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

            Graph graph = new Graph(edgeList);
            //This should return true
            bool isCycle = Algorithm.CycleInGraph(graph);
            Console.WriteLine(isCycle);
        }
    }
}
