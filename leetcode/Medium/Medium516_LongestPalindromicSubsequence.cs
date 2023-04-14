using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-palindromic-subsequence/
    /// </summary>
    public class Medium516_LongestPalindromicSubsequence
    {
        public int LongestPalindromeSubseq(string s)
        {
            var n = s.Length;
            var dp = new int[n][];

            for (var i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[n];
            }

            for (var i = n - 1; i >= 0; i--)
            {
                dp[i][i] = 1;

                for (var j = i + 1; j < n; j++)
                {
                    if (s[i] == s[j])
                    {
                        dp[i][j] = dp[i + 1][j - 1] + 2;
                    }
                    else
                    {
                        dp[i][j] = Math.Max(dp[i + 1][j], dp[i][j - 1]);
                    }
                }
            }

            return dp[0][n - 1];
        }
    }
}