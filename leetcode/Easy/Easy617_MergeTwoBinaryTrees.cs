using Leetcode.Utilities;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/merge-two-binary-trees/
    /// </summary>
    public class Easy617_MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return null;
            }

            root1 ??= new TreeNode();
            root2 ??= new TreeNode();

            var node = new TreeNode(root1.val + root2.val)
            {
                left = MergeTrees(root1.left, root2.left),
                right = MergeTrees(root1.right, root2.right)
            };

            return node;
        }
    }
}