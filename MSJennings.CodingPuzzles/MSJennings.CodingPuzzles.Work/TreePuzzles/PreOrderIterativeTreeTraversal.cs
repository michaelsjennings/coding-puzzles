using System.Collections.Generic;

namespace MSJennings.CodingPuzzles.Work.TreePuzzles
{
    public class PreOrderIterativeTreeTraversal
    {
        #region Public Methods

        public int[] GetResult(Tree tree)
        {
            var result = new List<int>();

            var nodeStack = new Stack<TreeNode>();
            nodeStack.Push(tree.Root);

            while (nodeStack.Count > 0)
            {
                var node = nodeStack.Pop();

                result.Add(node.Value);

                if (node.Right != null)
                {
                    nodeStack.Push(node.Right);
                }

                if (node.Left != null)
                {
                    nodeStack.Push(node.Left);
                }
            }

            return result.ToArray();
        }

        #endregion Public Methods
    }
}
