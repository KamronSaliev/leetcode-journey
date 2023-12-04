using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/invert-binary-tree/
    /// </summary>
    public class Easy226_InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root is null)
            {
                return null;
            }

            (root.left, root.right) = (root.right, root.left);
            InvertTree(root.right);
            InvertTree(root.left);
            return root;
        }
    }
}