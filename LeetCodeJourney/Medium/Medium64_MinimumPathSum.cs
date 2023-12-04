using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-path-sum/
    /// </summary>
    public class Medium64_MinimumPathSum
    {
        public int MinPathSum(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        grid[i][j] = grid[i][j];
                    }
                    else if (i != 0 && j == 0)
                    {
                        grid[i][j] += grid[i - 1][j];
                    }
                    else if (i == 0 && j != 0)
                    {
                        grid[i][j] += grid[i][j - 1];
                    }
                    else
                    {
                        grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
                    }
                }
            }

            return grid[n - 1][m - 1];
        }
    }
}