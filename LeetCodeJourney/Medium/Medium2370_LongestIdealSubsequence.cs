using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-ideal-subsequence
    /// </summary>
    public class Medium2370_LongestIdealSubsequence
    {
        public int LongestIdealString(string s, int k)
        {
            var dp = new int[26];
            var result = 0;

            foreach (var character in s)
            {
                var index = character - 'a';
                var currentMaxLength = 0;

                for (var i = Math.Max(0, index - k); i <= Math.Min(25, index + k); i++)
                {
                    currentMaxLength = Math.Max(currentMaxLength, dp[i]);
                }

                dp[index] = currentMaxLength + 1;
                result = Math.Max(result, dp[index]);
            }

            return result;
        }
    }
}