using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/construct-quad-tree/
    /// </summary>
    public class Medium427_ConstructQuadTree
    {
        public QuadNode Construct(int[][] grid)
        {
            return BuildTree(grid, 0, 0, grid.Length);
        }

        private QuadNode BuildTree(int[][] grid, int x, int y, int size)
        {
            if (size == 1)
            {
                return new QuadNode(grid[x][y] == 1, true);
            }
            
            var topLeft = BuildTree(grid, x, y, size / 2);
            var topRight = BuildTree(grid, x, y + size / 2, size / 2);
            var bottomLeft = BuildTree(grid, x + size / 2, y, size / 2);
            var bottomRight = BuildTree(grid, x + size / 2, y + size / 2, size / 2);

            var node = new QuadNode();

            if (topLeft.isLeaf && topRight.isLeaf && bottomLeft.isLeaf && bottomRight.isLeaf &&
                topLeft.val == topRight.val && topRight.val == bottomLeft.val && bottomLeft.val == bottomRight.val)
            {
                node.isLeaf = true;
                node.val = topLeft.val;
            }
            else
            {
                node.topLeft = topLeft;
                node.topRight = topRight;
                node.bottomLeft = bottomLeft;
                node.bottomRight = bottomRight;
            }

            return node;
        }
    }
}