using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-string-chain/
    /// </summary>
    public class Medium1048_LongestStringChain
    {
        public int LongestStrChain(string[] words)
        {
            Array.Sort(words, (a, b) => a.Length.CompareTo(b.Length));

            var dp = new Dictionary<string, int>();
            var maxChain = 0;

            foreach (var word in words)
            {
                dp[word] = 1;

                for (var i = 0; i < word.Length; i++)
                {
                    var previousWord = word.Remove(i, 1);

                    if (dp.ContainsKey(previousWord))
                    {
                        dp[word] = Math.Max(dp[word], dp[previousWord] + 1);
                    }
                }

                maxChain = Math.Max(maxChain, dp[word]);
            }

            return maxChain;
        }
    }
}