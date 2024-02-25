using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public static class GraphHelper
    {
        public static void DisplayGraph(Graph graph)
        {
            if(graph == null || graph.VertexAdjacencyNodes == null)
            {
                return;
            }

            foreach(var entry in graph.VertexAdjacencyNodes)
            {
                var nodes = entry.Value;
                foreach(var node in nodes)
                {
                    Console.Write("Vertex: " + entry.Key + "-->" + node.Vertex + "|" + node.Weight + "\t");
                }
                Console.WriteLine( );
            }
        }

        public static void DepthFirstTraversal(Graph graph, string rootVertex)
        {
            if(graph == null || graph.VertexAdjacencyNodes == null)
            {
                return;
            }

            var depthFirstOrder = new List<string>();
            var vertexStack = new Stack<string>();
            vertexStack.Push(rootVertex);
            while(vertexStack.Count > 0)
            {
                var currentVertex = vertexStack.Pop();
                depthFirstOrder.Add(currentVertex);
                if(graph.VertexAdjacencyNodes.TryGetValue(currentVertex, out var value))
                {
                    var nodes = value;
                    foreach(var node in nodes)
                    {
                        if(!depthFirstOrder.Contains(node.Vertex) && !vertexStack.Contains(node.Vertex))
                        {
                            vertexStack.Push(node.Vertex);
                        }
                    }
                }
            }

            foreach(var vertex in depthFirstOrder)
            {
                Console.Write(vertex + " ");
            }

            Console.WriteLine( );
        }

        public static void BreadthFirstTraversal(Graph graph, string rootVertex)
        {
            if(graph == null || graph.VertexAdjacencyNodes == null)
            {
                return;
            }

            var breadthFirstOrder = new List<string>();
            var vertexQueue = new Queue<string>();
            vertexQueue.Enqueue(rootVertex);
            while(vertexQueue.Count > 0)
            {
                var currentVertex = vertexQueue.Dequeue();
                breadthFirstOrder.Add(currentVertex);
                if(graph.VertexAdjacencyNodes.TryGetValue(currentVertex, out var value))
                {
                    var nodes = value;
                    foreach(var node in nodes)
                    {
                        if(!breadthFirstOrder.Contains(node.Vertex) && !breadthFirstOrder.Contains(node.Vertex))
                        {
                            vertexQueue.Enqueue(node.Vertex);
                        }
                    }
                }
            }

            foreach(var vertex in breadthFirstOrder)
            {
                Console.Write(vertex + " ");
            }

            Console.WriteLine( );
        }
    }
}
