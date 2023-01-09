using System.Collections.Generic;
using Leetcode.Utilities;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/binary-tree-inorder-traversal/
    /// </summary>
    public class Easy94_BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            return InorderTraversal(root, result);
        }

        private IList<int> InorderTraversal(TreeNode current, IList<int> result)
        {
            if (current == null)
            {
                return result;
            }

            InorderTraversal(current.left, result);
            result.Add(current.val);
            InorderTraversal(current.right, result);

            return result;
        }
    }
}