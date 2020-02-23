using System.Collections.Generic;

namespace MSJennings.CodingPuzzles.Work.TreePuzzles
{
    public class PreOrderRecursiveTreeTraversal
    {
        #region Public Methods

        public int[] GetResult(Tree tree)
        {
            var result = new List<int>();

            Traverse(tree.Root, result);

            return result.ToArray();
        }

        #endregion Public Methods

        #region Private Methods

        private void Traverse(TreeNode node, List<int> result)
        {
            result.Add(node.Value);

            if (node.Left != null)
            {
                Traverse(node.Left, result);
            }

            if (node.Right != null)
            {
                Traverse(node.Right, result);
            }
        }

        #endregion Private Methods
    }
}
