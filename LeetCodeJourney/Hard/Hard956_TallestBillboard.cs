using System;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/tallest-billboard/
    /// </summary>
    public class Hard956_TallestBillboard
    {
        public int TallestBillboard(int[] rods)
        {
            var sum = rods.Sum();

            var dp = new int[sum + 1];
            for (var i = 1; i <= sum; i++)
            {
                dp[i] = -1;
            }

            foreach (var rod in rods)
            {
                var dpClone = (int[])dp.Clone();
                for (var i = 0; i <= sum - rod; i++)
                {
                    if (dpClone[i] < 0)
                    {
                        continue;
                    }

                    dp[i + rod] = Math.Max(dp[i + rod], dpClone[i]);
                    dp[Math.Abs(i - rod)] = Math.Max(dp[Math.Abs(i - rod)], dpClone[i] + Math.Min(i, rod));
                }
            }

            return dp[0];
        }
    }
}