using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimize-maximum-pair-sum-in-array/
    /// </summary>
    public class Medium1877_MinimizeMaximumPairSumInArray
    {
        public int MinPairSum(int[] nums)
        {
            Array.Sort(nums);

            var result = int.MinValue;
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                result = Math.Max(result, nums[left] + nums[right]);
                left++;
                right--;
            }

            return result;
        }
    }
}