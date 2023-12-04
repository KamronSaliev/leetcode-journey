using System;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/balanced-binary-tree/
    /// </summary>
    public class Easy110_BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            
            var leftDepth = GetDepth(root.left);
            var rightDepth = GetDepth(root.right);

            if (Math.Abs(rightDepth - leftDepth) > 1)
            {
                return false;
            }

            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        private int GetDepth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return Math.Max(GetDepth(node.left), GetDepth(node.right)) + 1;
        }
    }
}