using System.Collections.Generic;
using TreeNode = LeetCode.Utilities.TreeNode;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/binary-tree-level-order-traversal/
    /// </summary>
    public class Medium102_BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            Queue<(TreeNode Node, int Level)> queue = new();
            
            queue.Enqueue((root, 0));

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (result.Count <= current.Level)
                {
                    result.Add(new List<int>());
                }
                
                result[current.Level].Add(current.Node.val);

                if (current.Node.left != null)
                {
                    queue.Enqueue((current.Node.left, current.Level + 1));
                }
                
                if (current.Node.right != null)
                {
                    queue.Enqueue((current.Node.right, current.Level + 1));
                }
            }

            return result;
        }
    }
}