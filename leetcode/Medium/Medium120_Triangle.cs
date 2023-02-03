using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/triangle/
    /// </summary>
    public class Medium120_Triangle
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            var rows = triangle.Count;

            if (rows == 0)
            {
                return 0;
            }

            var dp = new int[rows];

            for (var i = 0; i < triangle[rows - 1].Count; i++)
            {
                dp[i] = triangle[rows - 1][i];
            }

            for (var row = rows - 2; row >= 0; row--)
            {
                for (var col = 0; col <= row; col++)
                {
                    dp[col] = Math.Min(dp[col], dp[col + 1]) + triangle[row][col];
                }
            }

            return dp[0];
        }
    }
}