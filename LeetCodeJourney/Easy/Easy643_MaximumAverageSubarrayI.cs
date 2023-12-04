using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-average-subarray-i/
    /// </summary>
    public class Easy643_MaximumAverageSubarrayI
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            var sum = 0.0d;
            var average = 0.0d;

            for (var i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            average = sum / k;

            for (var i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                average = Math.Max(average, sum / k);
            }

            return average;
        }
    }
}