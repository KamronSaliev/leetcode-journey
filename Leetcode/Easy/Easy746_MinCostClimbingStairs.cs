using System;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/min-cost-climbing-stairs/
    /// </summary>
    public class Easy746_MinCostClimbingStairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            var dp = new int[cost.Length + 1];

            for (int i = 2; i < dp.Length; i++)
            {
                dp[i] = Math.Min(dp[i - 2] + cost[i - 2], dp[i - 1] + cost[i - 1]);
            }

            return dp[^1];
        }
    }
}