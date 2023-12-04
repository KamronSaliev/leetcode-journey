using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/jump-game/
    /// </summary>
    public class Medium55_JumpGame
    {
        public bool CanJump(int[] nums)
        {
            var max = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (i > max)
                {
                    return false;
                }

                max = Math.Max(max, nums[i] + i);
            }

            return true;
        }
    }
}