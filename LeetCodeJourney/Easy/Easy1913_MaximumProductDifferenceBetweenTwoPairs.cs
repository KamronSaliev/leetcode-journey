using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-product-difference-between-two-pairs/
    /// </summary>
    public class Easy1913_MaximumProductDifferenceBetweenTwoPairs
    {
        public int MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);

            return nums[^1] * nums[^2] - nums[0] * nums[1];
        }
    }
}