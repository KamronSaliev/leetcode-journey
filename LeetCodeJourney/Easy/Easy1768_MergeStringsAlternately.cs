using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/merge-strings-alternately/
    /// </summary>
    public class Easy1768_MergeStringsAlternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            var length = 2 * Math.Max(word1.Length, word2.Length);
            var mergedArray = new char[length];
            var merged = string.Empty;

            for (var i = 0; i < word1.Length; i++)
            {
                mergedArray[i * 2] = word1[i];
            }

            for (var i = 0; i < word2.Length; i++)
            {
                mergedArray[i * 2 + 1] = word2[i];
            }

            for (var i = 0; i < mergedArray.Length; i++)
            {
                if (char.IsLetter(mergedArray[i]))
                {
                    merged += mergedArray[i];
                }
            }

            return merged;
        }
    }
}