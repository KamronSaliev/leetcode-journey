using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-subarray-of-1s-after-deleting-one-element/
    /// </summary>
    public class Medium1493_LongestSubarrayOfOnesAfterDeletingOneElement
    {
        public int LongestSubarray(int[] nums)
        {
            var max = 0;
            var current = 0;
            var last = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    current++;
                }
                else if (current > 0)
                {
                    max = Math.Max(max, current + last);
                    last = current;
                    current = 0;
                }
                else
                {
                    last = 0;
                }
            }

            if (current == nums.Length)
            {
                return current - 1;
            }

            return Math.Max(max, current + last);
        }
    }
}