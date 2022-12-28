using System;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/house-robber/
    /// </summary>
    public class Medium198_HouseRobber
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
        
            var dp = new int[nums.Length];

            dp[0] = nums[0];
            dp[1] = Math.Max(dp[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
            }

            return dp[^1];
        }

    }
}