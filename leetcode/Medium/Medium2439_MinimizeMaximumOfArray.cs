using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimize-maximum-of-array/
    /// </summary>
    public class Medium2439_MinimizeMaximumOfArray
    {
        public int MinimizeArrayValue(int[] nums)
        {
            var sum = 0L;
            var result = 0L;
            
            for (var i = 0; i < nums.Length; ++i)
            {
                sum += nums[i];
                result = Math.Max(result, (sum + i) / (i + 1));
            }

            return (int)result;
        }
    }
}