using System;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-square-streak-in-an-array/
    /// TODO: Solve, Time Limit Exceeded
    /// </summary>
    public class Medium6258_LongestSquareStreakInAnArray
    {
        public int LongestSquareStreak(int[] nums)
        {
            Array.Sort(nums);

            var max = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                var counter = -1;

                var square = nums[i] * nums[i];

                if (nums.Contains(square))
                {
                    counter += 2;
                }

                while (nums.Contains(square))
                {
                    square *= square;
                    counter++;
                }

                if (counter > max)
                {
                    max = counter;
                }
            }

            return max;
        }
    }
}