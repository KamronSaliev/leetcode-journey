using System;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/house-robber/
    /// </summary>
    public class Medium198_HouseRobber
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            nums[1] = Math.Max(nums[0], nums[1]);

            for (var i = 2; i < nums.Length; i++)
            {
                nums[i] = Math.Max(nums[i - 1], nums[i - 2] + nums[i]);
            }

            return nums[^1];
        }
    }
}