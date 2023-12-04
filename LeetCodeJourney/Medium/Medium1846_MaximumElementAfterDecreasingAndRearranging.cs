using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-element-after-decreasing-and-rearranging/
    /// </summary>
    public class Medium1846_MaximumElementAfterDecreasingAndRearranging
    {
        public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
        {
            Array.Sort(arr);

            var result = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                result = Math.Min(arr[i], result + 1);
            }

            return result;
        }
    }
}