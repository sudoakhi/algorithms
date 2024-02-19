using Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs.GraphTraversal
{
    internal static class Algorithm
    {
        internal static void DepthFirstTraversal(Graph graph, string rootVertex)
        {
            var depthFirstOrder = new List<string>();
            var vertexStack = new Stack<string>();
            vertexStack.Push(rootVertex);
            while(vertexStack.Count > 0)
            {
                var currentVertex = vertexStack.Pop();
                depthFirstOrder.Add(currentVertex);
                if(graph._vertexAdjacencyNodes.TryGetValue(currentVertex , out var value) )
                {
                    var nodes = value;
                    foreach (var node in nodes)
                    {
                        if (!depthFirstOrder.Contains(node._vertex) && !vertexStack.Contains(node._vertex))
                        {
                            vertexStack.Push(node._vertex);
                        }
                    }
                }
            }

            foreach(var vertex in depthFirstOrder)
            {
                Console.Write(vertex + " ");
            }

            Console.WriteLine();
        }

        internal static void BreadthFirstTraversal(Graph graph, string rootVertex)
        {
            var breadthFirstOrder = new List<string>();
            var vertexQueue = new Queue<string>();
            vertexQueue.Enqueue(rootVertex);
            while (vertexQueue.Count > 0)
            {
                var currentVertex = vertexQueue.Dequeue();
                breadthFirstOrder.Add(currentVertex);
                if (graph._vertexAdjacencyNodes.TryGetValue(currentVertex , out var value) )
                {
                    var nodes = value;
                    foreach (var node in nodes)
                    {
                        if (!breadthFirstOrder.Contains(node._vertex) && !breadthFirstOrder.Contains(node._vertex))
                        {
                            vertexQueue.Enqueue(node._vertex);
                        }
                    }
                }
            }

            foreach (var vertex in breadthFirstOrder)
            {
                Console.Write(vertex + " ");
            }

            Console.WriteLine();
        }
    }
}
