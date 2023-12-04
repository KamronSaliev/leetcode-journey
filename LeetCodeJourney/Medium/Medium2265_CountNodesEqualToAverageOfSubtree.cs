using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/count-nodes-equal-to-average-of-subtree/
    /// </summary>
    public class Medium2265_CountNodesEqualToAverageOfSubtree
    {
        private int _result;

        public int AverageOfSubtree(TreeNode root)
        {
            Traverse(root);

            return _result;
        }

        private (int, int) Traverse(TreeNode node)
        {
            if (node == null)
            {
                return (0, 0);
            }

            var (leftSum, leftCount) = Traverse(node.left);
            var (rightSum, rightCount) = Traverse(node.right);

            var currentSum = node.val + leftSum + rightSum;
            var currentCount = 1 + leftCount + rightCount;

            if (currentSum / currentCount == node.val)
            {
                _result++;
            }

            return (currentSum, currentCount);
        }
    }
}