using System;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/reverse-words-in-a-string/
    /// </summary>
    public class Medium151_ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            return string.Join(' ', s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
        }
    }
}