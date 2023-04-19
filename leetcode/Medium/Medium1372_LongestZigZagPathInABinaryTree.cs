using System;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-zigzag-path-in-a-binary-tree/
    /// </summary>
    public class Medium1372_LongestZigZagPathInABinaryTree
    {
        private int _longestPath;

        public int LongestZigZag(TreeNode root)
        {
            DFS(root, 0, 0);
            return _longestPath;
        }

        private void DFS(TreeNode root, int left, int right)
        {
            if (root == null)
            {
                return;
            }

            _longestPath = Math.Max(_longestPath, Math.Max(left, right));

            if (root.left != null)
            {
                DFS(root.left, right + 1, 0);
            }

            if (root.right != null)
            {
                DFS(root.right, 0, left + 1);
            }
        }
    }
}