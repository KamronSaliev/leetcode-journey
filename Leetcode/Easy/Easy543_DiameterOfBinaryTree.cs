using System;
using Leetcode.Utilities;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/diameter-of-binary-tree/
    /// </summary>
    public class Easy543_DiameterOfBinaryTree
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            var diameter = 0;
            
            DFS(root, ref diameter);

            return diameter;
        }

        private int DFS(TreeNode node, ref int diameter)
        {
            if (node == null)
            {
                return 0;
            }

            var leftDiameter = DFS(node.left, ref diameter);
            var rightDiameter = DFS(node.right, ref diameter);

            diameter = Math.Max(diameter, leftDiameter + rightDiameter);

            return Math.Max(leftDiameter, rightDiameter) + 1;
        }
    }
}