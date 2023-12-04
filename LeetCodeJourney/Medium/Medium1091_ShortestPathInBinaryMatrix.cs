using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/shortest-path-in-binary-matrix/
    /// </summary>
    public class Medium1091_ShortestPathInBinaryMatrix
    {
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            var queue = new Queue<int[]>();

            var directions = new List<int[]>
            {
                new[] { -1, 0 }, new[] { 1, 0 }, new[] { 0, 1 }, new[] { 0, -1 },
                new[] { 1, -1 }, new[] { -1, -1 }, new[] { -1, 1 }, new[] { 1, 1 }
            };

            var m = grid.Length;
            var n = grid[0].Length;

            if (grid[0][0] != 0 || grid[m - 1][n - 1] != 0)
            {
                return -1;
            }

            queue.Enqueue(new[] { 0, 0 });
            grid[0][0] = 1;

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                var x = current[0];
                var y = current[1];

                if (x == m - 1 && y == n - 1)
                {
                    return grid[x][y];
                }

                foreach (var direction in directions)
                {
                    var newX = x + direction[0];
                    var newY = y + direction[1];

                    if (newX < 0 || newX >= m || newY < 0 || newY >= n || grid[newX][newY] != 0)
                    {
                        continue;
                    }

                    queue.Enqueue(new[] { newX, newY });
                    grid[newX][newY] = grid[x][y] + 1;
                }
            }

            return -1;
        }
    }
}