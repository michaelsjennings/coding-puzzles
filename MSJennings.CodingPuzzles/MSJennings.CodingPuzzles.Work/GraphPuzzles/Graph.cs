using System.Collections.Generic;

namespace MSJennings.CodingPuzzles.Work.GraphPuzzles
{
    public class Graph
    {
        #region Public Constructors

        public Graph()
        {
            Nodes = new Dictionary<int, IList<int>>();
        }

        #endregion Public Constructors

        #region Public Properties

        public IDictionary<int, IList<int>> Nodes { get; set; }

        #endregion Public Properties
    }
}
