using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/binary-tree-postorder-traversal/
    /// </summary>
    public class Easy145_BinaryTreePostorderTraversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            return PostorderTraversal(root, result);
        }

        private IList<int> PostorderTraversal(TreeNode current, List<int> result)
        {
            if (current == null)
            {
                return result;
            }

            PostorderTraversal(current.left, result);
            PostorderTraversal(current.right, result);
            result.Add(current.val);

            return result;
        }
    }
}