using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/path-with-maximum-gold/
    /// </summary>
    public class Medium1219_PathWithMaximumGold
    {
        public int GetMaximumGold(int[][] grid)
        {
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] != 0)
                    {
                        result = Math.Max(result, DFS(grid, i, j));
                    }
                }
            }

            return result;
        }

        private int DFS(int[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == 0)
            {
                return 0;
            }

            var currentGold = grid[i][j];
            grid[i][j] = 0;

            var maxGold = 0;
            maxGold = Math.Max(maxGold, currentGold + DFS(grid, i + 1, j));
            maxGold = Math.Max(maxGold, currentGold + DFS(grid, i - 1, j));
            maxGold = Math.Max(maxGold, currentGold + DFS(grid, i, j + 1));
            maxGold = Math.Max(maxGold, currentGold + DFS(grid, i, j - 1));

            grid[i][j] = currentGold;

            return maxGold;
        }
    }
}