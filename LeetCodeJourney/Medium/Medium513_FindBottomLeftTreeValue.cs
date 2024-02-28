using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-bottom-left-tree-value/
    /// </summary>
    public class Medium513_FindBottomLeftTreeValue
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            var leftValues = new List<int>();
            DFS(root, 0, leftValues);

            return leftValues[^1];
        }

        private void DFS(TreeNode node, int level, List<int> leftValues)
        {
            if (node == null)
            {
                return;
            }

            if (level == leftValues.Count)
            {
                leftValues.Add(node.val);
            }

            DFS(node.left, level + 1, leftValues);
            DFS(node.right, level + 1, leftValues);
        }
    }
}