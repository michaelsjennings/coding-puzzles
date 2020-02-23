using MSJennings.CodingPuzzles.Work.TreePuzzles;

namespace MSJennings.CodingPuzzles.Tests.TreePuzzleTests
{
    public static class TreePuzzleTestsHelper
    {
        #region Public Methods

        public static Tree GetTestTree()
        {
            /*
                    1
                   / \
                  2   3
                 / \   \
                4   5   6
                   /
                  7
            */

            var tree = new Tree();

            tree.Root = new TreeNode { Value = 1 };
            tree.Root.Left = new TreeNode { Value = 2 };
            tree.Root.Right = new TreeNode { Value = 3 };
            tree.Root.Left.Left = new TreeNode { Value = 4 };
            tree.Root.Left.Right = new TreeNode { Value = 5 };
            tree.Root.Right.Right = new TreeNode { Value = 6 };
            tree.Root.Left.Right.Left = new TreeNode { Value = 7 };

            return tree;
        }

        #endregion Public Methods
    }
}
