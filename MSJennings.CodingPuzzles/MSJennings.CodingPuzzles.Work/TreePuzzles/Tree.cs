namespace MSJennings.CodingPuzzles.Work.TreePuzzles
{
    public class Tree
    {
        #region Public Properties

        public TreeNode Root { get; set; }

        #endregion Public Properties
    }

    public class TreeNode
    {
        #region Public Properties

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        public int Value { get; set; }

        #endregion Public Properties
    }
}
