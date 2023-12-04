using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/frequency-of-the-most-frequent-element/
    /// </summary>
    public class Medium1838_FrequencyOfTheMostFrequentElement
    {
        public int MaxFrequency(int[] nums, int k)
        {
            Array.Sort(nums);
            var result = 1;
            var operations = 0;
            var left = 0;

            for (var right = 1; right < nums.Length; right++)
            {
                operations += (nums[right] - nums[right - 1]) * (right - left);

                while (operations > k)
                {
                    operations -= nums[right] - nums[left];
                    left++;
                }

                result = Math.Max(result, right - left + 1);
            }

            return result;
        }
    }
}