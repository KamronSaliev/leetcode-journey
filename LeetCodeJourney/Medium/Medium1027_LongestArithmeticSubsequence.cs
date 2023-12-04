using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-arithmetic-subsequence/
    /// </summary>
    public class Medium1027_LongestArithmeticSubsequence
    {
        public int LongestArithSeqLength(int[] nums)
        {
            var dp = new Dictionary<(int, int), int>();
            var maxLength = 2;

            for (var i = nums.Length - 2; i >= 0; i--)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    var difference = nums[j] - nums[i];
                    var length = 2;

                    if (dp.ContainsKey((j, difference)))
                    {
                        length = dp[(j, difference)] + 1;
                        maxLength = Math.Max(length, maxLength);
                    }

                    if (!dp.ContainsKey((i, difference)))
                    {
                        dp.Add((i, difference), length);
                    }
                    else
                    {
                        dp[(i, difference)] = Math.Max(dp[(i, difference)], length);
                    }
                }
            }

            return maxLength;
        }
    }
}