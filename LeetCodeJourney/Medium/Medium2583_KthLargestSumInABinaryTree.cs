using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/kth-largest-sum-in-a-binary-tree/
    /// </summary>
    public class Medium2583_KthLargestSumInABinaryTree
    {
        public long KthLargestLevelSum(TreeNode root, int k)
        {
            var level = 0;
            var result = BFS(root, ref level);

            result.Sort();

            if (k >= 0 && k <= level)
            {
                return result[^k];
            }

            return -1;
        }

        private List<long> BFS(TreeNode root, ref int level)
        {
            var result = new List<long>();

            if (root == null)
            {
                return result;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var size = queue.Count;
                var sum = 0L;

                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    sum += current.val;

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

                result.Add(sum);
                level++;
            }

            return result;
        }
    }
}