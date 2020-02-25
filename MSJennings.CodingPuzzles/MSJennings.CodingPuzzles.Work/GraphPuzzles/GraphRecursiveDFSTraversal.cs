using System.Collections.Generic;
using System.Linq;

namespace MSJennings.CodingPuzzles.Work.GraphPuzzles
{
    public class GraphRecursiveDFSTraversal
    {
        #region Public Methods

        public int[] GetResult(Graph graph)
        {
            var visited = new HashSet<int>();

            foreach (var node in graph.Nodes.Keys)
            {
                Visit(node, graph, visited);
            }

            return visited.ToArray();
        }

        #endregion Public Methods

        #region Private Methods

        private void Visit(int node, Graph graph, HashSet<int> visited)
        {
            if (!visited.Contains(node))
            {
                visited.Add(node);

                var neighbors = graph.Nodes[node];

                foreach (var neighbor in neighbors)
                {
                    Visit(neighbor, graph, visited);
                }
            }
        }

        #endregion Private Methods
    }
}
