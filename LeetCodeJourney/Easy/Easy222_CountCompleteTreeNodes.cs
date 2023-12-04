using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/count-complete-tree-nodes/
    /// </summary>
    public class Easy222_CountCompleteTreeNodes
    {
        public int CountNodes(TreeNode n)
        {
            return n is null ? 0 : 1 + CountNodes(n.left) + CountNodes(n.right);
        }
    }
}