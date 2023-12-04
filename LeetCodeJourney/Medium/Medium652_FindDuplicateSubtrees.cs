using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-duplicate-subtrees/
    /// </summary>
    public class Medium652_FindDuplicateSubtrees
    {
        private readonly Dictionary<string, int> _subtreeOccurrences = new();
        private readonly List<TreeNode> _result = new();

        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            DFS(root);

            return _result;
        }

        private string DFS(TreeNode node)
        {
            var leftSubtreeString = string.Empty;
            var rightSubtreeString = string.Empty;
            var currentString = node.val.ToString();

            if (node.left != null)
            {
                leftSubtreeString = DFS(node.left);
            }

            if (node.right != null)
            {
                rightSubtreeString = DFS(node.right);
            }

            // storing subtree structure in string representation using postorder traversal
            var structure = $"{currentString}L{leftSubtreeString}R{rightSubtreeString}";

            if (!_subtreeOccurrences.ContainsKey(structure))
            {
                _subtreeOccurrences.Add(structure, 1);
            }
            else
            {
                _subtreeOccurrences[structure]++;
            }

            // adding subtree root of the duplicate
            if (_subtreeOccurrences[structure] == 2)
            {
                _result.Add(node);
            }

            return structure;
        }
    }
}