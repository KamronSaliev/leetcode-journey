using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/add-one-row-to-tree
    /// </summary>
    public class Medium623_AddOneRowToTree
    {
        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (depth == 1)
            {
                return new TreeNode(val, root);
            }

            var currentDepth = 1;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                if (currentDepth == depth - 1)
                {
                    break;
                }

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

                currentDepth++;
            }

            foreach (var node in queue)
            {
                var leftNode = node.left;
                node.left = new TreeNode(val, leftNode);
                var rightNode = node.right;
                node.right = new TreeNode(val, null, rightNode);
            }

            return root;
        }
    }
}