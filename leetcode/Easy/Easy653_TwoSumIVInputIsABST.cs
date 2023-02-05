using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
    /// </summary>
    public class Easy653_TwoSumIVInputIsABST
    {
        private readonly HashSet<int> _values = new();

        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null)
            {
                return false;
            }

            if (_values.Contains(k - root.val))
            {
                return true;
            }

            _values.Add(root.val);
            
            return FindTarget(root.left, k) || FindTarget(root.right, k);
        }
    }
}