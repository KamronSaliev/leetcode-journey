using System;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-depth-of-n-ary-tree/
    /// </summary>
    public class Easy559_MaximumDepthOfNaryTree
    {
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            var height = 0;

            foreach (var child in root.children)
            {
                height = Math.Max(height, MaxDepth(child));
            }

            return height + 1;
        }
    }
}