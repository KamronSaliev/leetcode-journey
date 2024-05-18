using System;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/distribute-coins-in-binary-tree
    /// </summary>
    public class Medium979_DistributeCoinsInBinaryTree
    {
        private int _result;

        public int DistributeCoins(TreeNode root)
        {
            DFS(root);

            return _result;
        }

        private int DFS(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            var left = DFS(node.left);
            var right = DFS(node.right);

            _result += Math.Abs(left) + Math.Abs(right);

            return node.val + left + right - 1;
        }
    }
}