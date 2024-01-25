using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-common-subsequence/
    /// </summary>
    public class Medium1143_LongestCommonSubsequence
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            var m = text1.Length;
            var n = text2.Length;

            var dp = new int[n + 1];

            for (var i = 1; i <= m; i++)
            {
                var previous = 0;

                for (var j = 1; j <= n; j++)
                {
                    var temp = dp[j];

                    if (text1[i - 1] == text2[j - 1])
                    {
                        dp[j] = previous + 1;
                    }
                    else
                    {
                        dp[j] = Math.Max(dp[j], dp[j - 1]);
                    }
            
                    previous = temp;
                }
            }

            return dp[n];
        }
    }
}