using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/set-mismatch/
    /// </summary>
    public class Easy645_SetMismatch
    {
        public int[] FindErrorNums(int[] nums)
        {
            var n = nums.Length;
            var sum = n * (n + 1) / 2;
            var dict = new Dictionary<int, bool>(n);
            var currentSum = 0;
            var duplicate = -1;

            foreach (var num in nums)
            {
                if (dict.TryAdd(num, true))
                {
                    currentSum += num;
                }
                else
                {
                    duplicate = num;
                }
            }

            var miss = sum - currentSum;

            return new[] { duplicate, miss };
        }
    }
}