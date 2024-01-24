using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/pseudo-palindromic-paths-in-a-binary-tree/
    /// </summary>
    public class Medium1457_PseudoPalindromicPathsInABinaryTree
    {
        public int PseudoPalindromicPaths(TreeNode root)
        {
            var result = 0;
            var set = new HashSet<int>();

            DFS(root, set, ref result);

            return result;
        }

        private void DFS(TreeNode root, HashSet<int> set, ref int count)
        {
            if (root == null)
            {
                return;
            }

            if (!set.Add(root.val))
            {
                set.Remove(root.val);
            }

            if (root.left == null && root.right == null)
            {
                if (set.Count < 2)
                {
                    count++;
                }
            }
            else
            {
                DFS(root.left, set, ref count);
                DFS(root.right, set, ref count);
            }

            if (!set.Remove(root.val))
            {
                set.Add(root.val);
            }
        }
    }
}