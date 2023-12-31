using System;
using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/largest-substring-between-two-equal-characters/
    /// </summary>
    public class Easy1624_LargestSubstringBetweenTwoEqualCharacters
    {
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            Dictionary<char, int> lastIndices = new();
            var result = -1;

            for (var i = 0; i < s.Length; i++)
            {
                if (lastIndices.ContainsKey(s[i]))
                {
                    var length = i - lastIndices[s[i]] - 1;
                    result = Math.Max(result, length);
                }
                else
                {
                    lastIndices[s[i]] = i;
                }
            }

            return result;
        }
    }
}