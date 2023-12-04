using System;
using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-largest-value-in-each-tree-row/
    /// </summary>
    public class Medium515_FindLargestValueInEachTreeRow
    {
        public IList<int> LargestValues(TreeNode root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var size = queue.Count;
                var currentMax = int.MinValue;

                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    currentMax = Math.Max(currentMax, current.val);

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

                result.Add(currentMax);
            }

            return result;
        }
    }
}