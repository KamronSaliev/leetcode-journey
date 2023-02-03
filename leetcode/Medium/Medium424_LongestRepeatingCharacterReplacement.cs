using System;
using System.Collections.Generic;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-repeating-character-replacement/
    /// </summary>
    public class Medium424_LongestRepeatingCharacterReplacement
    {
        public int CharacterReplacement(string s, int k)
        {
            var map = new Dictionary<char, int>();

            var leftBorder = 0;
            var result = 0;
            var max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], 1);
                }
                else
                {
                    map[s[i]]++;
                }

                max = Math.Max(map[s[i]], max);

                while (i - leftBorder + 1 - max > k)
                {
                    map[s[leftBorder]]--;
                    leftBorder++;
                }

                result = Math.Max(i - leftBorder + 1, result);
            }

            return result;
        }
    }
}