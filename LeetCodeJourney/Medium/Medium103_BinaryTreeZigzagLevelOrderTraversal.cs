using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
    /// </summary>
    public class Medium103_BinaryTreeZigzagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            var queue = new Queue<TreeNode>();
            var level = 0;
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var size = queue.Count;
                var levelNodes = new List<int>();

                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    levelNodes.Add(current.val);

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

                if (level % 2 == 0)
                {
                    result.Add(new List<int>(levelNodes));
                }
                else
                {
                    levelNodes.Reverse();
                    result.Add(new List<int>(levelNodes));
                }

                level++;
            }

            return result;
        }
    }
}