using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/check-if-all-characters-have-equal-number-of-occurrences
    /// </summary>
    public class Easy1941_CheckIfAllCharactersHaveEqualNumberOfOccurrences
    {
        public bool AreOccurrencesEqual(string s)
        {
            var occurrences = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
            {
                if (occurrences.ContainsKey(s[i]))
                {
                    occurrences[s[i]]++;
                }
                else
                {
                    occurrences.Add(s[i], 1);
                }
            }

            var count = occurrences.First().Value;

            foreach (var occurrence in occurrences)
            {
                if (occurrence.Value != count)
                {
                    return false;
                }
            }

            return true;
        }
    }
}