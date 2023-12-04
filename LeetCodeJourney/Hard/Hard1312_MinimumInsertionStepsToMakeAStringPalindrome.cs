using System;
using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-insertion-steps-to-make-a-string-palindrome/
    /// </summary>
    public class Hard1312_MinimumInsertionStepsToMakeAStringPalindrome
    {
        public int MinInsertions(string s)
        {
            var dictionary = new Dictionary<(int, int), int>();
            return Min(dictionary, s, 0, s.Length - 1);
        }

        private int Min(Dictionary<(int, int), int> dictionary, string s, int left, int right)
        {
            if (dictionary.ContainsKey((left, right)))
            {
                return dictionary[(left, right)];
            }

            while (left < right && s[left] == s[right])
            {
                left++;
                right--;
            }

            if (left >= right)
            {
                return 0;
            }

            dictionary[(left, right)] =
                1 + Math.Min(Min(dictionary, s, left + 1, right), Min(dictionary, s, left, right - 1));
            return dictionary[(left, right)];
        }
    }
}