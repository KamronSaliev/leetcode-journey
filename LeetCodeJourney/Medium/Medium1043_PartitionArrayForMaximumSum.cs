using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/partition-array-for-maximum-sum/
    /// </summary>
    public class Medium1043_PartitionArrayForMaximumSum
    {
        public int MaxSumAfterPartitioning(int[] arr, int k)
        {
            var n = arr.Length;
            var dp = new int[n + 1];

            for (var i = 1; i <= n; i++)
            {
                var max = 0;
                
                for (var j = 1; j <= k && i - j >= 0; j++)
                {
                    max = Math.Max(max, arr[i - j]);
                    dp[i] = Math.Max(dp[i], dp[i - j] + max * j);
                }
            }

            return dp[n];
        }
    }
}