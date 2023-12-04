using System;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/
    /// </summary>
    public class Medium1026_MaximumDifferenceBetweenNodeAndAncestor
    {
        public int MaxAncestorDiff(TreeNode root)
        {
            return DFS(root, int.MinValue, int.MaxValue);
        }

        private int DFS(TreeNode node, int max, int min)
        {
            if (node == null)
            {
                return max - min;
            }

            max = Math.Max(max, node.val);
            min = Math.Min(min, node.val);

            return node.left == node.right ? 
                max - min : 
                Math.Max(DFS(node.left, max, min), DFS(node.right, max, min));
        }
    }
}