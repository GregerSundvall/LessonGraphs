using System.Collections.Generic;

namespace LessonGraphs
{
    public class Graph
    {
        private List<IVertex> vertices;
        private HashSet<Edge> edges;
        
        public int Order
        {
            get { return vertices.Count; }
        }
        public int Size
        {
            get { return edges.Count; }
        }
        
        public IVertex[] Vertices
        {
            get { return vertices.ToArray(); }
        }
        
        public Edge[] Edges
        {
            get
            {
                Edge[] retval = new Edge[edges.Count];
                edges.CopyTo(retval);
                return retval;
            }
        }

        public void AddVertex(IVertex vertex)
        {
            vertices.Add(vertex);
        }

        public void AddEdge(IVertex v1, IVertex v2, float weight = 1f)
        {
            edges.Add(v1.AddEdge(v2, weight));
            edges.Add(v2.AddEdge(v1, weight));
        }
        
        public Graph()
        {
            vertices = new List<IVertex>();
            edges = new HashSet<Edge>();
        }
        
    }
}