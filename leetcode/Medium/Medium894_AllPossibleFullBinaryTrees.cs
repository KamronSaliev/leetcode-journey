using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/all-possible-full-binary-trees/
    /// </summary>
    public class Medium894_AllPossibleFullBinaryTrees
    {
        public IList<TreeNode> AllPossibleFBT(int n)
        {
            var result = new List<TreeNode>();

            if (n % 2 == 0)
            {
                return result;
            }

            if (n == 1)
            {
                result.Add(new TreeNode(0));
                return result;
            }

            for (var i = 1; i <= n - 2; i += 2)
            {
                var left = AllPossibleFBT(i);
                var right = AllPossibleFBT(n - 1 - i);

                foreach (var l in left)
                {
                    foreach (var r in right)
                    {
                        var root = new TreeNode(0)
                        {
                            left = l,
                            right = r
                        };
                        result.Add(root);
                    }
                }
            }

            return result;
        }
    }
}