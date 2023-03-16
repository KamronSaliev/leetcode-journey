using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
    /// </summary>
    public class Medium106_ConstructBinaryTreeFromInorderAndPostorder
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            return buildTree(inorder, 0, inorder.Length - 1,
                postorder, 0, postorder.Length - 1);
        }

        private TreeNode buildTree(int[] inorder, int inorderLeft, int inderRight,
            int[] postorder, int postorderLeft, int postorderRight)
        {
            if (inorderLeft > inderRight || postorderLeft > postorderRight)
            {
                return null;
            }

            var rootVal = postorder[postorderRight];
            var root = new TreeNode(rootVal);

            var rootIndex = 0;
            for (var i = inorderLeft; i <= inderRight; i++)
            {
                if (inorder[i] != rootVal)
                {
                    continue;
                }

                rootIndex = i;
                break;
            }

            var leftSize = rootIndex - inorderLeft;
            var rightSize = inderRight - rootIndex;

            root.left = buildTree(inorder, inorderLeft, rootIndex - 1,
                postorder, postorderLeft, postorderLeft + leftSize - 1);
            root.right = buildTree(inorder, rootIndex + 1, inderRight,
                postorder, postorderRight - rightSize, postorderRight - 1);

            return root;
        }
    }
}