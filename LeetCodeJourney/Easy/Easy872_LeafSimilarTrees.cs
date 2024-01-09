using System.Text;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/leaf-similar-trees/
    /// </summary>
    public class Easy872_LeafSimilarTrees
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var stringBuilder1 = new StringBuilder();
            var stringBuilder2 = new StringBuilder();
            DFS(root1, ref stringBuilder1);
            DFS(root2, ref stringBuilder2);
            return stringBuilder1.ToString() == stringBuilder2.ToString();
        }

        private void DFS(TreeNode root, ref StringBuilder stringBuilder)
        {
            if (root is null)
            {
                return;
            }

            if (root.left is null && root.right is null)
            {
                var value = $"_{root.val}";
                stringBuilder?.Append(value);
            }

            DFS(root.left, ref stringBuilder);
            DFS(root.right, ref stringBuilder);
        }
    }
}