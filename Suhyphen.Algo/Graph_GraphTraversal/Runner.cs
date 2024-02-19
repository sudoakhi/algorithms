using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Graph_GraphTraversal
{
    internal class Runner
    {
        public static void Run()
        {
            Edge edge1 = new Edge("1", "2", 0);
            Edge edge2 = new Edge("1", "8", 0);
            Edge edge3 = new Edge("1", "4", 0);
            Edge edge4 = new Edge("1", "9", 0);
            Edge edge5 = new Edge("2", "5", 0);
            Edge edge6 = new Edge("2", "7", 0);
            Edge edge7 = new Edge("3", "6", 0);
            Edge edge8 = new Edge("4", "11", 0);
            Edge edge9 = new Edge("5", "7", 0);
            Edge edge10 = new Edge("7", "2", 0);
            Edge edge11 = new Edge("9", "4", 0);
            Edge edge12 = new Edge("9", "10", 0);

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
                edge10,
                edge11,
                edge12,
            };

            Graph graph = new Graph(edgeList);
            Console.WriteLine("---------- Graph Content ----------");
            GraphHelper.DisplayGraph(graph);
            Console.WriteLine("---------- Depth First Traversal ----------");
            Algorithm.DepthFirstTraversal(graph, "1");
            Console.WriteLine("---------- Breadth First Traversal ----------");
            Algorithm.BreadthFirstTraversal(graph, "1");
        }
    }
}
