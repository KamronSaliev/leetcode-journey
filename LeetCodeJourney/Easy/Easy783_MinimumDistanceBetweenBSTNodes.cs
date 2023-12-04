using System;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-distance-between-bst-nodes/
    /// </summary>
    public class Easy783_MinimumDistanceBetweenBSTNodes
    {
        private int _minDistance = int.MaxValue;
        private TreeNode _previous;

        public int MinDiffInBST(TreeNode root)
        {
            InorderTraversal(root);

            return _minDistance;
        }

        private void InorderTraversal(TreeNode current)
        {
            if (current == null)
            {
                return;
            }

            InorderTraversal(current.left);

            if (_previous != null)
            {
                _minDistance = Math.Min(_minDistance, Math.Abs(current.val - _previous.val));
            }

            _previous = current;

            InorderTraversal(current.right);
        }
    }
}