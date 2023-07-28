using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/predict-the-winner/
    /// </summary>
    public class Medium486_PredictTheWinner
    {
        public bool PredictTheWinner(int[] nums)
        {
            var n = nums.Length;
            var dp = new int[n, n];

            for (var i = n - 1; i >= 0; --i)
            {
                for (var j = i; j < n; ++j)
                {
                    if (i == j)
                    {
                        dp[i, j] = nums[i];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(nums[i] - dp[i + 1, j], nums[j] - dp[i, j - 1]);
                    }
                }
            }

            return dp[0, n - 1] >= 0;
        }
    }
}