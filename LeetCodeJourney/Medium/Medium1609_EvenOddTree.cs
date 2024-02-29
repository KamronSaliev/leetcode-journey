using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/even-odd-tree/
    /// </summary>
    public class Medium1609_EvenOddTree
    {
        public bool IsEvenOddTree(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var isLevelEven = true;

            while (queue.Count != 0)
            {
                var size = queue.Count;
                var previous = isLevelEven ? int.MinValue : int.MaxValue;
                var isCurrentLevelEven = isLevelEven;

                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();

                    if ((isCurrentLevelEven && (current.val % 2 == 0 || current.val <= previous)) ||
                        (!isCurrentLevelEven && (current.val % 2 != 0 || current.val >= previous)))
                    {
                        return false;
                    }

                    previous = current.val;

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

                isLevelEven = !isLevelEven;
            }

            return true;
        }
    }
}