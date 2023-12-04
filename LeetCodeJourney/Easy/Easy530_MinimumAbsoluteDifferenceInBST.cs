using System;
using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-absolute-difference-in-bst/
    /// </summary>
    public class Easy530_MinimumAbsoluteDifferenceInBST
    {
        public int GetMinimumDifference(TreeNode root)
        {
            var inOrderList = new List<int>();
            inOrderList = InorderTraversal(root, inOrderList);

            var result = int.MaxValue;
            
            for (var i = 1; i < inOrderList.Count; i++)
            {
                result = Math.Min(result, inOrderList[i] - inOrderList[i - 1]);
            }

            return result;
        }

        private List<int> InorderTraversal(TreeNode current, List<int> result)
        {
            if (current == null)
            {
                return result;
            }

            InorderTraversal(current.left, result);
            result.Add(current.val);
            InorderTraversal(current.right, result);

            return result;
        }
    }
}