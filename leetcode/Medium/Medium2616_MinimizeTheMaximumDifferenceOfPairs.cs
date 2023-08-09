using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimize-the-maximum-difference-of-pairs/
    /// </summary>
    public class Medium2616_MinimizeTheMaximumDifferenceOfPairs
    {
        public int MinimizeMax(int[] nums, int p)
        {
            Array.Sort(nums);

            var left = 0;
            var right = nums[^1] - nums[0];

            while (left < right)
            {
                var mid = left + (right - left) / 2;
                var count = 0;
                
                for (var i = 1; i < nums.Length && count < p; i++)
                {
                    if (nums[i] - nums[i - 1] <= mid)
                    {
                        count++;
                        i++;
                    }
                }

                if (count >= p)
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