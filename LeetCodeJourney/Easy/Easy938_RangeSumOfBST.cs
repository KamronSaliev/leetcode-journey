using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/range-sum-of-bst/
    /// </summary>
    public class Easy938_RangeSumOfBST
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root is null)
            {
                return 0;
            }

            if (root.val < low)
            {
                return RangeSumBST(root.right, low, high);
            }

            if (root.val > high)
            {
                return RangeSumBST(root.left, low, high);
            }

            return root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
        }
    }
}