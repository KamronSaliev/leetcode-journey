using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/binary-search-tree-iterator/
    /// </summary>
    public class Medium173_BinarySearchTreeIterator
    {
        /**
         * Your BSTIterator object will be instantiated and called as such:
         * BSTIterator obj = new BSTIterator(root);
         * int param_1 = obj.Next();
         * bool param_2 = obj.HasNext();
         */
        public class BSTIterator
        {
            private readonly List<int> _tree = new();
            private int _index;

            public BSTIterator(TreeNode root)
            {
                InorderTraversal(root, _tree);
            }

            public int Next()
            {
                return _tree[_index++];
            }

            public bool HasNext()
            {
                return _index < _tree.Count;
            }

            private void InorderTraversal(TreeNode current, IList<int> list)
            {
                if (current == null)
                {
                    return;
                }

                InorderTraversal(current.left, list);
                list.Add(current.val);
                InorderTraversal(current.right, list);
            }
        }
    }
}