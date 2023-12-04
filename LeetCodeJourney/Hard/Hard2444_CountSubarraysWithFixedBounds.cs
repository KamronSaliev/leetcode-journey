using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/count-subarrays-with-fixed-bounds/
    /// </summary>
    public class Hard2444_CountSubarraysWithFixedBounds
    {
        public long CountSubarrays(int[] nums, int minK, int maxK)
        {
            var result = 0L;
            var currentMinIndex = -1;
            var currentMaxIndex = -1;
            var startIndex = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= minK && nums[i] <= maxK)
                {
                    currentMinIndex = nums[i] == minK ? i : currentMinIndex;
                    currentMaxIndex = nums[i] == maxK ? i : currentMaxIndex;
                    result += Math.Max(0, Math.Min(currentMinIndex, currentMaxIndex) - startIndex + 1);
                }
                else
                {
                    currentMinIndex = -1;
                    currentMaxIndex = -1;
                    startIndex = i + 1;
                }
            }

            return result;
        }
    }
}