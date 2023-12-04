using LeetCode.Utilities;

namespace LeetCode.Medium
{
    public class Medium129_SumRootToLeafNumbers
    {
        private int _sum;

        public int SumNumbers(TreeNode root)
        {
            DFS(root, 0);

            return _sum;
        }

        private void DFS(TreeNode node, int currentValue)
        {
            if (node == null)
            {
                return;
            }

            currentValue = currentValue * 10 + node.val;

            if (node.left == null && node.right == null)
            {
                _sum += currentValue;
                return;
            }

            DFS(node.left, currentValue);
            DFS(node.right, currentValue);
        }
    }
}