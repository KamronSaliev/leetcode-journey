using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/extra-characters-in-a-string/
    /// </summary>
    public class Medium2707_ExtraCharactersInAString
    {
        public int MinExtraChar(string s, string[] dictionary)
        {
            var dp = new int[s.Length + 1];
            Array.Fill(dp, int.MaxValue);
            dp[0] = 0;

            var hashSet = new HashSet<string>(dictionary);

            for (var i = 1; i <= s.Length; i++)
            {
                dp[i] = dp[i - 1] + 1;

                for (var j = 1; j <= i; j++)
                {
                    if (hashSet.Contains(s.Substring(i - j, j)))
                    {
                        dp[i] = Math.Min(dp[i], dp[i - j]);
                    }
                }
            }

            return dp[s.Length];
        }
    }
}