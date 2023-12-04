using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/same-tree/
    /// </summary>
    public class Easy100_SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == q)
            {
                return true;
            }
        
            if (p == null || q == null)
            {
                return false;
            }

            if (p.val != q.val)
            {
                return false;
            }

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}