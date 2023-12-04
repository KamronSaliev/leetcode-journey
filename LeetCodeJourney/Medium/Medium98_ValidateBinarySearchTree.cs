using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/validate-binary-search-tree/
    /// </summary>
    public class Medium98_ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            return root == null || IsValidBST(root, long.MinValue, long.MaxValue);
        }

        private bool IsValidBST(TreeNode node, long min, long max)
        {
            if (node == null)
            {
                return true;
            }

            if (node.val <= min || node.val >= max)
            {
                return false;
            }

            return IsValidBST(node.left, min, node.val) && IsValidBST(node.right, node.val, max);
        }
    }
}