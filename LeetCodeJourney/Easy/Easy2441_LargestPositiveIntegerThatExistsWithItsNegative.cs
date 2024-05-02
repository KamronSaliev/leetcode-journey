using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/largest-positive-integer-that-exists-with-its-negative
    /// </summary>
    public class Easy2441_LargestPositiveIntegerThatExistsWithItsNegative
    {
        public int FindMaxK(int[] nums)
        {
            Array.Sort(nums);

            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var negative = -nums[right];

                if (nums[left] == negative)
                {
                    return nums[right];
                }

                if (nums[left] < negative)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return -1;
        }
    }
}