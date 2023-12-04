using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/sum-of-left-leaves/
    /// </summary>
    public class Easy404_SumOfLeftLeaves
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var sum = 0;

            var tree = new Stack<TreeNode>();
            tree.Push(root);

            while (tree.Count != 0)
            {
                var node = tree.Pop();

                if (node.left != null)
                {
                    if (node.left.left == null && node.left.right == null)
                    {
                        sum += node.left.val;
                    }
                    else
                    {
                        tree.Push(node.left);
                    }
                }

                if (node.right == null)
                {
                    continue;
                }

                if (node.right.left != null || node.right.right != null)
                {
                    tree.Push(node.right);
                }
            }

            return sum;
        }
    }
}