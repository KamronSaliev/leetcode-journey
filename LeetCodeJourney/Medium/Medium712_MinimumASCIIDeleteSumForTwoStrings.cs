using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-ascii-delete-sum-for-two-strings/
    ///     https://leetcode.com/problems/minimum-ascii-delete-sum-for-two-strings/solutions/3840553/100-dp-video-decoding-approach-to-minimum-ascii-delete-sum/
    /// </summary>
    public class Medium712_MinimumASCIIDeleteSumForTwoStrings
    {
        public int MinimumDeleteSum(string s1, string s2)
        {
            var dp = new int[s1.Length + 1, s2.Length + 1];

            for (var i = 1; i <= s1.Length; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + s1[i - 1];
            }

            for (var j = 1; j <= s2.Length; j++)
            {
                dp[0, j] = dp[0, j - 1] + s2[j - 1];
            }

            for (var i = 1; i <= s1.Length; i++)
            {
                for (var j = 1; j <= s2.Length; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j] + s1[i - 1], dp[i, j - 1] + s2[j - 1]);
                    }
                }
            }

            return dp[s1.Length, s2.Length];
        }
    }
}