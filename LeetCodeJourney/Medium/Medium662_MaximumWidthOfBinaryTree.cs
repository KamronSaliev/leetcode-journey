using System;
using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-width-of-binary-tree/
    ///     https://leetcode.com/problems/maximum-width-of-binary-tree/solutions/3438491/easy-to-understand-c-solution-using-bfs/
    /// </summary>
    public class Medium662_MaximumWidthOfBinaryTree
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            var maxWidth = 0;
            var queue = new Queue<(TreeNode Node, int Index)>();
            queue.Enqueue((root, 0));

            while (queue.Count != 0)
            {
                var size = queue.Count;
                var left = queue.Peek().Index;
                var right = left;

                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    right = current.Index;

                    if (current.Node.left != null)
                    {
                        queue.Enqueue((current.Node.left, 2 * current.Index + 1));
                    }

                    if (current.Node.right != null)
                    {
                        queue.Enqueue((current.Node.right, 2 * current.Index + 2));
                    }
                }

                maxWidth = Math.Max(maxWidth, right - left + 1);
            }

            return maxWidth;
        }
    }
}