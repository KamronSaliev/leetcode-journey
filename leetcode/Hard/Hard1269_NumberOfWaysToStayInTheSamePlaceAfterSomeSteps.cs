using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-ways-to-stay-in-the-same-place-after-some-steps/
    /// </summary>
    public class Hard1269_NumberOfWaysToStayInTheSamePlaceAfterSomeSteps
    {
        public int NumWays(int steps, int arrLen)
        {
            var m = steps;
            var n = Math.Min(steps / 2 + 1, arrLen);

            var dp = new int[m + 1, n];
            dp[0, 0] = 1;

            var mod = (int)1e9 + 7;

            for (var i = 1; i <= m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    dp[i, j] = dp[i - 1, j];
                    
                    if (j > 0)
                    {
                        dp[i, j] = (dp[i, j] + dp[i - 1, j - 1]) % mod;
                    }

                    if (j < n - 1)
                    {
                        dp[i, j] = (dp[i, j] + dp[i - 1, j + 1]) % mod;
                    }
                }
            }

            return dp[m, 0];
        }
    }
}