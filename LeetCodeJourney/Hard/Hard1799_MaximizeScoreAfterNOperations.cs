using System;
using System.Collections.Generic;
using System.Numerics;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/maximize-score-after-n-operations/
    /// </summary>
    public class Hard1799_MaximizeScoreAfterNOperations
    {
        public int MaxScore(int[] nums)
        {
            var n = nums.Length;
            var gcdValues = new Dictionary<int, int>();

            for (var i = 0; i < n; ++i)
            {
                for (var j = i + 1; j < n; ++j)
                {
                    gcdValues.Add((1 << i) + (1 << j), GCD(nums[i], nums[j]));
                }
            }

            var dp = new int[1 << n];

            for (var i = 0; i < 1 << n; ++i)
            {
                var bits = BitOperations.PopCount((uint)i);

                // Skip odd numbers
                if (bits % 2 != 0)
                {
                    continue;
                }

                foreach (var (k, v) in gcdValues)
                {
                    // Skip overlapping numbers
                    if ((k & i) != 0)
                    {
                        continue;
                    }

                    dp[i ^ k] = Math.Max(dp[i ^ k], dp[i] + v * (bits / 2 + 1));
                }
            }

            return dp[(1 << n) - 1];
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}