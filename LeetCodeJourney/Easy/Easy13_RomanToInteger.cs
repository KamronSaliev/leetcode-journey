using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    public class Easy13_RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var dict = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            var number = dict[s[^1]];

            for (var i = s.Length - 2; i >= 0; i--)
            {
                number += dict[s[i]] >= dict[s[i + 1]] ? dict[s[i]] : -dict[s[i]];
            }

            return number;
        }
    }
}