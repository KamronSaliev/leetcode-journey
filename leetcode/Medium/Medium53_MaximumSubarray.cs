using System;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-subarray/
    /// </summary>
    public class Medium53_MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            var maxForCurrentIndex = nums[0];
            var ans = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                maxForCurrentIndex = Math.Max(maxForCurrentIndex + nums[i], nums[i]);
                ans = Math.Max(ans, maxForCurrentIndex);
            }

            return ans;
        }
    }
}