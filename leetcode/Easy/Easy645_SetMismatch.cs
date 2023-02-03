using System.Collections.Generic;

namespace Leetcode.Easy
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
            var miss = -1;
            var duplicate = -1;

            for (var i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], true);
                    currentSum += nums[i];
                }
                else
                {
                    duplicate = nums[i];
                }
            }

            miss = sum - currentSum;

            return new[] { duplicate, miss };
        }
    }
}