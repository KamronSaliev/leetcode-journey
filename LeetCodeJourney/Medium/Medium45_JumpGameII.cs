using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/jump-game-ii/
    /// </summary>
    public class Medium45_JumpGameII
    {
        public int Jump(int[] nums)
        {
            var arr = new int[nums.Length];

            for (var i = 1; i < arr.Length; i++)
            {
                arr[i] = int.MaxValue;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 1; j <= nums[i] && i + j < nums.Length; j++)
                {
                    arr[i + j] = Math.Min(arr[i + j], arr[i] + 1);
                }
            }

            return arr[^1];
        }
    }
}