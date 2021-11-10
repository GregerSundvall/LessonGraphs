using System.Collections.Generic;
using System.Xml.Schema;

namespace LessonGraphs
{
    public interface IVertex
    {
        public dynamic Value { get; }
        public HashSet<Edge> Edges { get; }
        public Edge AddEdge(IVertex target, float weight = 1);
    }
}