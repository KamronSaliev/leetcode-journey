using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/unique-binary-search-trees-ii/
    /// </summary>
    public class Medium95_UniqueBinarySearchTreesII
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            return GenerateTrees(1, n);
        }

        private IList<TreeNode> GenerateTrees(int left, int right)
        {
            var result = new List<TreeNode>();

            if (left > right)
            {
                result.Add(null);
                return result;
            }

            for (var i = left; i <= right; i++)
            {
                var leftNodes = GenerateTrees(left, i - 1);
                var rightNodes = GenerateTrees(i + 1, right);

                foreach (var leftNode in leftNodes)
                {
                    foreach (var rightNode in rightNodes)
                    {
                        var node = new TreeNode(i, leftNode, rightNode);
                        result.Add(node);
                    }
                }
            }

            return result;
        }
    }
}