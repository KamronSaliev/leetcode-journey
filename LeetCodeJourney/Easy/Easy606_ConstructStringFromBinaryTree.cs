using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/construct-string-from-binary-tree/
    /// </summary>
    public class Easy606_ConstructStringFromBinaryTree
    {
        public string Tree2str(TreeNode root)
        {
            if (root == null)
            {
                return string.Empty;
            }

            if (root.left == null && root.right == null)
            {
                return root.val.ToString();
            }
            
            var left = $"({Tree2str(root.left)})";
            var right = $"{Tree2str(root.right)}" == string.Empty ? string.Empty : $"({Tree2str(root.right)})";
            return $"{root.val}{left}{right}";
        }
    }
}