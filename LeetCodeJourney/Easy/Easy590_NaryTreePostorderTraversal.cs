using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/n-ary-tree-postorder-traversal/
    /// </summary>
    public class Easy590_NaryTreePostorderTraversal
    {
        private readonly IList<int> _result = new List<int>();

        public IList<int> Postorder(Node root)
        {
            if (root == null)
            {
                return _result;
            }
            
            foreach (var node in root.children)
            {
                Postorder(node);
            }
            
            _result.Add(root.val);
            
            return _result;
        }
    }
}