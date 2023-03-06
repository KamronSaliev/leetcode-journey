using System;
using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-depth-of-binary-tree/
    /// </summary>
    public class Easy104_MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
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

            var leftMaxDepth = MaxDepth(root.left);
            var rightMaxDepth = MaxDepth(root.right);

            return Math.Max(leftMaxDepth, rightMaxDepth) + 1;
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
                }

                depth++;
            }

            return depth;
        }
    }
}