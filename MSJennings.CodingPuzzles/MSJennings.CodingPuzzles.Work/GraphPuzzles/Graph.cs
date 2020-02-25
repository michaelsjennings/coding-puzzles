using System;
using System.Collections.Generic;
using System.Linq;

namespace MSJennings.CodingPuzzles.Work.GraphPuzzles
{
    public class Graph<T>
    {
        #region Public Fields

        public readonly IList<GraphEdge<T>> Edges = new List<GraphEdge<T>>();

        public readonly IList<GraphNode<T>> Nodes = new List<GraphNode<T>>();

        #endregion Public Fields

        #region Public Methods

        public GraphEdge<T> AddEdge(string label, GraphNode<T> node1, GraphNode<T> node2)
        {
            if (node1.Graph != this || node2.Graph != this)
            {
                throw new InvalidOperationException();
            }

            var edge = new GraphEdge<T>(this, label, node1, node2);

            Edges.Add(edge);

            return edge;
        }

        public GraphNode<T> AddNode(T value)
        {
            var node = new GraphNode<T>(this, value);

            Nodes.Add(node);

            return node;
        }

        #endregion Public Methods
    }

    public class GraphEdge<T>
    {
        #region Public Fields

        public readonly Graph<T> Graph;

        public readonly string Label;

        public readonly GraphNode<T> Node1;

        public readonly GraphNode<T> Node2;

        #endregion Public Fields

        #region Public Constructors

        public GraphEdge(Graph<T> graph, string label, GraphNode<T> node1, GraphNode<T> node2)
        {
            Graph = graph;
            Label = label;
            Node1 = node1;
            Node2 = node2;
        }

        #endregion Public Constructors
    }

    public class GraphNode<T>
    {
        #region Public Fields

        public readonly Graph<T> Graph;

        public readonly T Value;

        #endregion Public Fields

        #region Public Constructors

        public GraphNode(Graph<T> graph, T value)
        {
            Graph = graph;
            Value = value;
        }

        #endregion Public Constructors

        #region Public Properties

        public IEnumerable<GraphEdge<T>> Edges => Graph.Edges.Where(e => e.Node1 == this || e.Node2 == this);

        #endregion Public Properties
    }
}
