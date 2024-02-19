using suhyphen.Algo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace suhyphen.Algo.Graph_GraphTraversal
{
    internal class Algorithm
    {
        public static void DepthFirstTraversal(Graph graph, string rootVertex)
        {
            List<string> depthFirstOrder = new List<string>();
            Stack<string> vertexStack = new Stack<string>();
            vertexStack.Push(rootVertex);
            while(vertexStack.Count > 0)
            {
                string currentVertex = vertexStack.Pop();
                depthFirstOrder.Add(currentVertex);
                if(graph.VertexAdjacencyNodes.ContainsKey(currentVertex))
                {
                    List<AdjacencyNode> nodes = graph.VertexAdjacencyNodes[currentVertex];
                    foreach (AdjacencyNode node in nodes)
                    {
                        if (!depthFirstOrder.Contains(node.Vertex) && !vertexStack.Contains(node.Vertex))
                        {
                            vertexStack.Push(node.Vertex);
                        }
                    }
                }
            }

            foreach(string vertex in depthFirstOrder)
            {
                Console.Write(vertex + " ");
            }

            Console.WriteLine();
        }

        public static void BreadthFirstTraversal(Graph graph, string rootVertex)
        {
            List<string> breadthFirstOrder = new List<string>();
            Queue<string> vertexQueue = new Queue<string>();
            vertexQueue.Enqueue(rootVertex);
            while (vertexQueue.Count > 0)
            {
                string currentVertex = vertexQueue.Dequeue();
                breadthFirstOrder.Add(currentVertex);
                if (graph.VertexAdjacencyNodes.ContainsKey(currentVertex))
                {
                    List<AdjacencyNode> nodes = graph.VertexAdjacencyNodes[currentVertex];
                    foreach (AdjacencyNode node in nodes)
                    {
                        if (!breadthFirstOrder.Contains(node.Vertex) && !breadthFirstOrder.Contains(node.Vertex))
                        {
                            vertexQueue.Enqueue(node.Vertex);
                        }
                    }
                }
            }

            foreach (string vertex in breadthFirstOrder)
            {
                Console.Write(vertex + " ");
            }

            Console.WriteLine();
        }
    }
}
