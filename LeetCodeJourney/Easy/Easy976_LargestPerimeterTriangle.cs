using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/largest-perimeter-triangle/
    /// </summary>
    public class Easy976_LargestPerimeterTriangle
    {
        public int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);

            var sum = 0;

            for (var i = nums.Length - 1; i >= 2; i--)
            {
                if (nums[i] < nums[i - 1] + nums[i - 2])
                {
                    sum = nums[i] + nums[i - 1] + nums[i - 2];
                    break;
                }
            }

            return sum;
        }
    }
}