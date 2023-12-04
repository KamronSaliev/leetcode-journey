using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree/
    /// </summary>
    public class Medium1161_MaximumLevelSumOfABinaryTree
    {
        public int MaxLevelSum(TreeNode root)
        {
            var level = 1;
            var currentLevel = 1;
            var maxLevelSum = int.MinValue;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var levelSum = 0;
                var size = queue.Count;

                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    levelSum += current.val;

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

                if (levelSum > maxLevelSum)
                {
                    maxLevelSum = levelSum;
                    level = currentLevel;
                }

                currentLevel++;
            }

            return level;
        }
    }
}