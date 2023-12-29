using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-difficulty-of-a-job-schedule/
    /// </summary>
    public class Hard1335_MinimumDifficultyOfAJobSchedule
    {
        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            var n = jobDifficulty.Length;

            if (n < d)
            {
                return -1;
            }

            var dp = new int[n + 1];
            Array.Fill(dp, int.MaxValue / 2);
            dp[n] = 0;

            for (var i = 1; i <= d; i++)
            {
                for (var j = 0; j <= n - i; j++)
                {
                    var maxDifficulty = 0;
                    dp[j] = int.MaxValue / 2;

                    for (var k = j; k <= n - i; k++)
                    {
                        maxDifficulty = Math.Max(maxDifficulty, jobDifficulty[k]);
                        dp[j] = Math.Min(dp[j], maxDifficulty + dp[k + 1]);
                    }
                }
            }

            return dp[0];
        }
    }
}