using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/determine-if-two-strings-are-close/
    /// </summary>
    public class Medium1657_DetermineIfTwoStringsAreClose
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            var frequency1 = new int[26];
            var frequency2 = new int[26];

            for (var i = 0; i < word1.Length; i++)
            {
                frequency1[word1[i] - 'a']++;
                frequency2[word2[i] - 'a']++;
            }

            for (var i = 0; i < 26; i++)
            {
                if ((frequency1[i] == 0 && frequency2[i] != 0) || (frequency1[i] != 0 && frequency2[i] == 0))
                {
                    return false;
                }
            }

            Array.Sort(frequency1);
            Array.Sort(frequency2);

            for (var i = 0; i < 26; i++)
            {
                if (frequency1[i] != frequency2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}