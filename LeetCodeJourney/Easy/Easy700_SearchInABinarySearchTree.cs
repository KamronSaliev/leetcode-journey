using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/search-in-a-binary-search-tree/
    /// </summary>
    public class Easy700_SearchInABinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            return root.val == val ? root : SearchBST(root.val > val ? root.left : root.right, val);
        }
    }
}