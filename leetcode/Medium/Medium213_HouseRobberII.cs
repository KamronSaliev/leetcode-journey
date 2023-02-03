using System;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/house-robber-ii/
    /// </summary>
    public class Medium213_HouseRobberII
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            // dp1, the first one is not chosen, the last and second one can be chosen
            // dp2, the first one is chosen, the last and second one are not chosen
            var dp1 = new int[nums.Length];
            var dp2 = new int[nums.Length];

            dp1[1] = nums[1];
            dp2[0] = nums[0];
            dp2[1] = Math.Max(nums[0], nums[1]);

            for (var i = 2; i < nums.Length; i++)
            {
                dp1[i] = Math.Max(dp1[i - 1], dp1[i - 2] + nums[i]);
            }

            for (var i = 2; i < nums.Length - 1; i++)
            {
                dp2[i] = Math.Max(dp2[i - 1], dp2[i - 2] + nums[i]);
            }

            return Math.Max(dp1[^1], dp2[^2]);
        }
    }
}