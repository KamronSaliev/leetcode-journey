using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/unique-paths-ii/
    ///     https://leetcode.com/problems/unique-paths-ii/solutions/3896905/100-dynamic-programming-video-optimal-solution/
    /// </summary>
    public class Medium63_UniquePathsII
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            if (obstacleGrid == null || obstacleGrid.Length == 0 || obstacleGrid[0].Length == 0 ||
                obstacleGrid[0][0] == 1)
            {
                return 0;
            }

            var m = obstacleGrid.Length;
            var n = obstacleGrid[0].Length;

            var previous = new int[n];
            var current = new int[n];
            previous[0] = 1;

            for (var i = 0; i < m; i++)
            {
                current[0] = obstacleGrid[i][0] == 1 ? 0 : previous[0];
                for (var j = 1; j < n; j++)
                {
                    current[j] = obstacleGrid[i][j] == 1 ? 0 : current[j - 1] + previous[j];
                }

                Array.Copy(current, previous, n);
            }

            return previous[n - 1];
        }
    }
}