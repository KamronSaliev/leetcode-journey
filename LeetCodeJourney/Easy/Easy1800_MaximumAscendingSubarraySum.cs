using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-ascending-subarray-sum
    /// </summary>
    public class Easy1800_MaximumAscendingSubarraySum
    {
        public int MaxAscendingSum(int[] nums)
        {
            var result = 0;
            var currentSum = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] < nums[i])
                {
                    currentSum += nums[i];
                }
                else
                {
                    result = Math.Max(currentSum, result);
                    currentSum = nums[i];
                }
            }

            result = Math.Max(currentSum, result);
            return result;
        }
    }
}