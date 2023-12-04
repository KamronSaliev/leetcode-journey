using System.Collections.Generic;
using System.Linq;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/check-completeness-of-a-binary-tree/
    /// </summary>
    public class Medium958_CheckCompletenessOfABinaryTree
    {
        public bool IsCompleteTree(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();

                // all nodes in the last level are as far left as possible,
                // so a complete tree does not have nonnull nodes after null was encountered
                if (current == null)
                {
                    return queue.All(node => node == null);
                }

                queue.Enqueue(current.left);
                queue.Enqueue(current.right);
            }

            return false;
        }
    }
}