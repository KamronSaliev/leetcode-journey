using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/unique-length-3-palindromic-subsequences/
    /// </summary>
    public class Medium1930_UniqueLength3PalindromicSubsequences
    {
        public int CountPalindromicSubsequence(string s)
        {
            var result = 0;

            for (var i = 0; i < 26; ++i)
            {
                var currentChar = (char)(i + 'a');
                var left = s.IndexOf(currentChar);
                var right = s.LastIndexOf(currentChar);
                if (left != -1 && right != -1 && left < right)
                {
                    result += new HashSet<char>(s.Substring(left + 1, right - left - 1)).Count;
                }
            }

            return result;
        }
    }
}