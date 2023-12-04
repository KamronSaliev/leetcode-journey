using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/
    /// </summary>
    public class Medium1456_MaximumNumberOfVowelsInASubstringOfGivenLength
    {
        public int MaxVowels(string s, int k)
        {
            var count = 0;

            for (var i = 0; i < k; i++)
            {
                if (IsVowel(s[i]))
                {
                    count++;
                }
            }

            var result = count;

            for (var i = k; i < s.Length; i++)
            {
                if (IsVowel(s[i - k]))
                {
                    count--;
                }

                if (IsVowel(s[i]))
                {
                    count++;
                }

                result = Math.Max(result, count);
            }

            return result;
        }

        private bool IsVowel(char c)
        {
            return c is 'a' or 'e' or 'i' or 'o' or 'u';
        }
    }
}