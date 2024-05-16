using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/evaluate-boolean-binary-tree
    /// </summary>
    public class Easy2331_EvaluateBooleanBinaryTree
    {
        public bool EvaluateTree(TreeNode node)
        {
            return node.val switch
            {
                0 => false,
                1 => true,
                2 => EvaluateTree(node.left) || EvaluateTree(node.right),
                3 => EvaluateTree(node.left) && EvaluateTree(node.right)
            };
        }
    }
}