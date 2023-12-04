using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/frog-jump-ii/
    /// </summary>
    public class Medium2498_FrogJumpII
    {
        public int MaxJump(int[] stones)
        {
            var ans = stones[1];

            for (var i = 2; i < stones.Length; i++)
            {
                ans = Math.Max(ans, stones[i] - stones[i - 2]);
            }

            return ans;
        }
    }
}