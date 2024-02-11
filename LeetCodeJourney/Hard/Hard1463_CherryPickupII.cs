using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/cherry-pickup-ii/
    ///     https://leetcode.com/problems/cherry-pickup-ii/solutions/4708659/intuitive-full-code-explained-java-c-c-javascript/
    /// </summary>
    public class Hard1463_CherryPickupII
    {
        public int CherryPickup(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var dp = new int[n][][];

            for (var i = 0; i < n; i++)
            {
                dp[i] = new int[m][];

                for (var j = 0; j < m; j++)
                {
                    dp[i][j] = new int[m];

                    for (var k = 0; k < m; k++)
                    {
                        dp[i][j][k] = -1;
                    }
                }
            }

            return DFS(grid, n, m, 0, 0, m - 1, dp);
        }

        private int DFS(int[][] grid, int n, int m, int r, int col1, int col2, int[][][] dp)
        {
            if (r < 0 || r >= n || col1 < 0 || col1 >= m || col2 < 0 || col2 >= m)
            {
                return 0;
            }

            if (dp[r][col1][col2] != -1)
            {
                return dp[r][col1][col2];
            }

            var maxCherries = 0;

            for (var i = -1; i <= 1; i++)
            {
                for (var j = -1; j <= 1; j++)
                {
                    var newCol1 = col1 + i;
                    var newCol2 = col2 + j;

                    maxCherries = Math.Max(maxCherries, DFS(grid, n, m, r + 1, newCol1, newCol2, dp));
                }
            }

            var current = col1 == col2 ? grid[r][col1] : grid[r][col1] + grid[r][col2];
            dp[r][col1][col2] = current + maxCherries;
            return dp[r][col1][col2];
        }
    }
}