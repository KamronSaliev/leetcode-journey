using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/largest-local-values-in-a-matrix
    /// </summary>
    public class Easy2373_LargestLocalValuesInAMatrix
    {
        public int[][] LargestLocal(int[][] grid)
        {
            var n = grid.Length;
            var result = new int[n - 2][];

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n - 2; j++)
                {
                    grid[i][j] = Math.Max(grid[i][j], Math.Max(grid[i][j + 1], grid[i][j + 2]));
                }
            }

            for (var i = 0; i < n - 2; i++)
            {
                result[i] = new int[n - 2];
                
                for (var j = 0; j < n - 2; j++)
                {
                    result[i][j] = Math.Max(grid[i][j], Math.Max(grid[i + 1][j], grid[i + 2][j]));
                }
            }

            return result;
        }
    }
}