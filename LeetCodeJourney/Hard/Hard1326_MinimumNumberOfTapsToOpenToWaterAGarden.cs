using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-number-of-taps-to-open-to-water-a-garden/
    /// </summary>
    public class Hard1326_MinimumNumberOfTapsToOpenToWaterAGarden
    {
        public int MinTaps(int n, int[] ranges)
        {
            var dp = new int[n + 1];
            Array.Fill(dp, n + 2);

            dp[0] = 0;

            for (var i = 0; i <= n; i++)
            {
                var start = Math.Max(0, i - ranges[i]);
                var end = Math.Min(n, i + ranges[i]);

                for (var j = start; j <= end; j++)
                {
                    dp[j] = Math.Min(dp[j], dp[start] + 1);
                }
            }

            return dp[n] == n + 2 ? -1 : dp[n];
        }
    }
}