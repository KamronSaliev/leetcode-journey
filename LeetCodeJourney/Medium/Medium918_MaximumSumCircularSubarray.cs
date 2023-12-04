using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-sum-circular-subarray/
    /// </summary>
    public class Medium918_MaximumSumCircularSubarray
    {
        public int MaxSubarraySumCircular(int[] nums)
        {
            var sum = 0;
            var maxSum = nums[0];
            var minSum = nums[0];
            var currentMax = 0;
            var currentMin = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                currentMax = Math.Max(currentMax + nums[i], nums[i]);
                maxSum = Math.Max(maxSum, currentMax);
                currentMin = Math.Min(currentMin + nums[i], nums[i]);
                minSum = Math.Min(minSum, currentMin);
                sum += nums[i];
            }

            return maxSum > 0 ? Math.Max(maxSum, sum - minSum) : maxSum;
        }
    }
}