using System;
using System.Collections.Generic;
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
            // solution by DFS approach
            // return DFS(root);

            return BFS(root);
        }

        private int DFS(TreeNode root)
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

        private int BFS(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var depth = 0;

            while (queue.Count != 0)
            {
                var size = queue.Count;

                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }

                    if (current.left == null && current.right == null)
                    {
                        return depth + 1;
                    }
                }

                depth++;
            }

            return 0;
        }
    }
}