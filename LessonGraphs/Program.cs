using System;

namespace LessonGraphs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Graph graph = new Graph();

            Vertex<int>[] vertices = new Vertex<int>[]
            {
                new Vertex<int>(1, graph),
                new Vertex<int>(2, graph),
                new Vertex<int>(3, graph),
                new Vertex<int>(4, graph),
                new Vertex<int>(5, graph),
                new Vertex<int>(6, graph)
            };
            
            graph.AddEdge(vertices[0], vertices[1], 4f);
            graph.AddEdge(vertices[0], vertices[2], 4f);
            graph.AddEdge(vertices[1], vertices[2], 2f);
            graph.AddEdge(vertices[2], vertices[3], 3f);
            graph.AddEdge(vertices[2], vertices[5], 6f);
            graph.AddEdge(vertices[2], vertices[4], 1f);
            graph.AddEdge(vertices[3], vertices[5], 2f);
            graph.AddEdge(vertices[4], vertices[5], 3f);

            Console.WriteLine("Order: {0}", graph.Order);
            Console.WriteLine("Size: {0}", graph.Size);
        }
    }
}