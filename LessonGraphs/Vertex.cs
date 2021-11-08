using System;
using System.Collections.Generic;

namespace LessonGraphs
{
    public class Vertex<T> : IVertex
    {
        private T value;
        private Type type;
        private HashSet<Edge> outgoing;
        private int indexInGraph;

        public Type Type
        {
            get { return Type; }
        }
        public dynamic Value
        {
            get { return value; }
        }
        public HashSet<Edge> Outgoing
        {
            get { return outgoing; }
        }
        public int IndexInGraph
        {
            get { return indexInGraph; }
        }

        public Edge AddEdge(IVertex target, float weight = 1)
        {
            Edge edge = new Edge(this, target, weight);
            outgoing.Add(edge);
            return edge;
        }
        
        public Vertex(T value)
        {
            this.type = typeof(T);
            this.value = value;
            this.outgoing = new HashSet<Edge>();
        }
                
        public Vertex(T value, Graph G)
        {
            this.type = typeof(T);
            this.value = value;
            this.outgoing = new HashSet<Edge>();
            this.indexInGraph = G.Order;
            G.AddVertex(this);
        }
    }
}