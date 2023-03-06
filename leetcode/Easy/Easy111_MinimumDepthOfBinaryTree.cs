using System;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-depth-of-binary-tree/
    /// </summary>
    public class Easy111_MinimumDepthOfBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var leftMinDepth = MinDepth(root.left);
            var rightMinDepth = MinDepth(root.right);

            if (leftMinDepth == 0 || rightMinDepth == 0)
            {
                return Math.Max(leftMinDepth, rightMinDepth) + 1;
            }
            
            return Math.Min(leftMinDepth, rightMinDepth) + 1;
        }
    }
}