using MSJennings.CodingPuzzles.Work.GraphPuzzles;

namespace MSJennings.CodingPuzzles.Tests.GraphPuzzleTests
{
    public static class GraphPuzzleTestsHelper
    {
        #region Public Methods

        public static Graph GetTestGraph()
        {
            /*
                        3 ---
                       /      \
                      /        \
                1 -- 2 --- 5    7 -- 8
                      \   /
                       \ /
                        4 --- 6
            */

            var graph = new Graph();
            graph.Nodes[1] = new[] { 2 };
            graph.Nodes[2] = new[] { 1, 3, 4, 5 };
            graph.Nodes[3] = new[] { 2, 7 };
            graph.Nodes[4] = new[] { 2, 5 };
            graph.Nodes[5] = new[] { 2, 4 };
            graph.Nodes[6] = new[] { 4 };
            graph.Nodes[7] = new[] { 3, 8 };
            graph.Nodes[8] = new[] { 7 };

            return graph;
        }

        #endregion Public Methods
    }
}
