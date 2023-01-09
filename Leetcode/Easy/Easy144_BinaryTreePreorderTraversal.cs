using System.Collections.Generic;
using Leetcode.Utilities;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/binary-tree-preorder-traversal/
    /// </summary>
    public class Easy144_BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            return PreorderTraversal(root, result);
        }

        private IList<int> PreorderTraversal(TreeNode current, IList<int> result)
        {
            if (current == null)
            {
                return result;
            }

            result.Add(current.val);
            PreorderTraversal(current.left, result);
            PreorderTraversal(current.right, result);

            return result;
        }
    }
}