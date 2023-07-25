using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/max-consecutive-ones-iii/
    /// </summary>
    public class Medium1004_MaxConsecutiveOnesIII
    {
        public int LongestOnes(int[] nums, int k)
        {
            var left = 0;
            var max = 0;
            var zerosCount = 0;

            for (var right = 0; right < nums.Length; right++)
            {
                zerosCount += 1 - nums[right];

                while (zerosCount > k)
                {
                    if (nums[left++] == 0)
                    {
                        zerosCount--;
                    }
                }

                max = Math.Max(max, right - left + 1);
            }

            return max;
        }
    }
}