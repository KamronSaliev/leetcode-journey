using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x/
    /// </summary>
    public class Easy1608_SpecialArrayWithXElementsGreaterThanOrEqualX
    {
        public int SpecialArray(int[] nums)
        {
            Array.Sort(nums);

            for (var i = 0; i <= nums[^1]; i++)
            {
                var index = BinarySearch(nums, i);

                if (nums.Length - index == i)
                {
                    return i;
                }
            }

            return -1;
        }

        private int BinarySearch(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            if (nums[left] >= target)
            {
                return left;
            }

            return -1;
        }
    }
}