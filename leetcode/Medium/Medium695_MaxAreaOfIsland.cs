using System;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/max-area-of-island/
    /// </summary>
    public class Medium695_MaxAreaOfIsland
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var maxArea = 0;

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    if (grid[i][j] != 1)
                    {
                        continue;
                    }

                    var area = DFS(grid, i, j, n, m);
                    maxArea = Math.Max(maxArea, area);
                }
            }

            return maxArea;
        }

        private int DFS(int[][] grid, int i, int j, int n, int m)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != 1)
            {
                return 0;
            }

            grid[i][j] = 0;

            return 1 + DFS(grid, i - 1, j, n, m) +
                   DFS(grid, i + 1, j, n, m) +
                   DFS(grid, i, j - 1, n, m) +
                   DFS(grid, i, j + 1, n, m);
        }
    }
}