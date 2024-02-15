using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-polygon-with-the-largest-perimeter/
    /// </summary>
    public class Medium2971_FindPolygonWithTheLargestPerimeter
    {
        public long LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);

            var result = 0L;
            var temp = 0L;

            for (var i = 0; i < nums.Length; i++)
            {
                if (temp <= nums[i])
                {
                    temp += nums[i];
                }
                else
                {
                    temp += nums[i];
                    result = temp;
                }
            }

            return result == 0 ? -1 : result;
        }
    }
}