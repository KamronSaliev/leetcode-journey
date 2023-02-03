using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/squares-of-a-sorted-array/
    /// </summary>
    public class Easy977_SquaresOfASortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            var n = nums.Length;
            var answers = new int[n];
            var l = 0;
            var r = n - 1;

            for (var k = n - 1; k >= 0; k--)
            {
                if (Math.Abs(nums[r]) > Math.Abs(nums[l]))
                {
                    answers[k] = nums[r] * nums[r];
                    r--;
                }
                else
                {
                    answers[k] = nums[l] * nums[l];
                    l++;
                }
            }

            return answers;
        }
    }
}