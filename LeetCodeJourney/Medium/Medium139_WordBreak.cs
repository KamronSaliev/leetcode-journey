using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/word-break/
    /// </summary>
    public class Medium139_WordBreak
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var n = s.Length;
            
            var dp = new bool[n + 1];
            dp[0] = true;
            
            var maxLength = 0;
            
            foreach (var word in wordDict)
            {
                maxLength = Math.Max(maxLength, word.Length);
            }

            for (var i = 1; i <= n; i++)
            {
                for (var j = i - 1; j >= Math.Max(i - maxLength - 1, 0); j--)
                {
                    if (dp[j] && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[n];
        }
    }
}