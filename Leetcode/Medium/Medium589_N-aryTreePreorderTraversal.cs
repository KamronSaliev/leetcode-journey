using System.Collections.Generic;
using Leetcode.Utilities;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/n-ary-tree-preorder-traversal/
    /// </summary>
    public class Medium589_N_aryTreePreorderTraversal
    {
        public IList<int> Preorder(Node root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            var stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                result.Add(current.val);

                for (var i = current.children.Count - 1; i >= 0; i--)
                {
                    stack.Push(current.children[i]);
                }
            }

            return result;
        }
    }
}