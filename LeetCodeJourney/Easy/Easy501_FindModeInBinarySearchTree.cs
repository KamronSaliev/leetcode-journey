using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/find-mode-in-binary-search-tree/
    /// </summary>
    public class Easy501_FindModeInBinarySearchTree
    {
        private readonly List<int> _modes = new();

        private int _currentValue;
        private int _currentCount;
        private int _maxCount;

        public int[] FindMode(TreeNode root)
        {
            InorderTraversal(root);
            return _modes.ToArray();
        }

        private void InorderTraversal(TreeNode current)
        {
            if (current == null)
            {
                return;
            }

            InorderTraversal(current.left);

            _currentCount = current.val == _currentValue ? _currentCount + 1 : 1;

            if (_currentCount == _maxCount)
            {
                _modes.Add(current.val);
            }
            else if (_currentCount > _maxCount)
            {
                _maxCount = _currentCount;
                _modes.Clear();
                _modes.Add(current.val);
            }

            _currentValue = current.val;

            InorderTraversal(current.right);
        }
    }
}