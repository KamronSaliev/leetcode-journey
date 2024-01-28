using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/n-ary-tree-preorder-traversal/
    /// </summary>
    public class Easy589_NaryTreePreorderTraversal
    {
        private readonly IList<int> _result = new List<int>();

        public IList<int> Preorder(Node root)
        {
            if (root == null)
            {
                return _result;
            }
            
            _result.Add(root.val);
            
            foreach (var node in root.children)
            {
                Preorder(node);
            }
            
            return _result;
        }
    }
}