using System;
using Leetcode.Utilities;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-depth-of-binary-tree/
    /// </summary>
    public class Easy104_MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var leftMaxDepth = MaxDepth(root.left);
            var rightMaxDepth = MaxDepth(root.right);

            return Math.Max(leftMaxDepth, rightMaxDepth) + 1;
        }
    }
}