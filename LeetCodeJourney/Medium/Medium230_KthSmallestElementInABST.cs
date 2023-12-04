using System;
using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/kth-smallest-element-in-a-bst/
    /// </summary>
    public class Medium230_KthSmallestElementInABST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            var result = InorderTraversal(root);

            Console.WriteLine(string.Join(" ", result));

            return result[k - 1];
        }

        private IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            return InorderTraversalInternal(root, result);
        }

        private IList<int> InorderTraversalInternal(TreeNode current, IList<int> result)
        {
            if (current == null)
            {
                return result;
            }

            InorderTraversalInternal(current.left, result);
            result.Add(current.val);
            InorderTraversalInternal(current.right, result);

            return result;
        }
    }
}