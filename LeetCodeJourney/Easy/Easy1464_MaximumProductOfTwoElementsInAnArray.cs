using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/
    /// </summary>
    public class Easy1464_MaximumProductOfTwoElementsInAnArray
    {
        public int MaxProduct(int[] nums)
        {
            Array.Sort(nums);

            return (nums[^1] - 1) * (nums[^2] - 1);
        }
    }
}