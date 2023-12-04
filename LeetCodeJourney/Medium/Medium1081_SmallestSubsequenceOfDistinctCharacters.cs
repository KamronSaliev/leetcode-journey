using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/smallest-subsequence-of-distinct-characters/
    /// </summary>
    public class Medium1081_SmallestSubsequenceOfDistinctCharacters
    {
        public string SmallestSubsequence(string s)
        {
            var lastOccurenceIndices = new int[26];
            var visited = new bool[26];
            var stack = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                lastOccurenceIndices[s[i] - 'a'] = i;
            }

            for (var i = 0; i < s.Length; i++)
            {
                var currentChar = s[i];

                if (visited[currentChar - 'a'])
                {
                    continue;
                }

                while (stack.Count > 0 && currentChar < stack.Peek() && i < lastOccurenceIndices[stack.Peek() - 'a'])
                {
                    visited[stack.Pop() - 'a'] = false;
                }

                stack.Push(currentChar);
                visited[currentChar - 'a'] = true;
            }

            var result = stack.ToArray();
            Array.Reverse(result);
            return new string(result);
        }
    }
}