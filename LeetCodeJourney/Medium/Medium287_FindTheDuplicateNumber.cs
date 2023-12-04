using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-the-duplicate-number/
    /// </summary>
    public class Medium287_FindTheDuplicateNumber
    {
        public int FindDuplicate(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var mid = (int)(left + (right - left) * 0.5f);
                var count = 0;

                for (var i = 0; i < nums.Length; i++)
                {
                    if (nums[i] <= mid)
                    {
                        count++;
                    }
                }

                if (count > mid)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }
}