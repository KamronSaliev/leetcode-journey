using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique/
    /// </summary>
    public class Medium1647_MinimumDeletionsToMakeCharacterFrequenciesUnique
    {
        public int MinDeletions(string s)
        {
            var frequencies = new Dictionary<char, int>();
            var usedFrequencies = new HashSet<int>();
            var deletions = 0;

            foreach (var c in s)
            {
                if (frequencies.ContainsKey(c))
                {
                    frequencies[c]++;
                }
                else
                {
                    frequencies[c] = 1;
                }
            }

            foreach (var count in frequencies.Values)
            {
                var currentFrequency = count;

                while (currentFrequency > 0 && usedFrequencies.Contains(currentFrequency))
                {
                    currentFrequency--;
                    deletions++;
                }

                usedFrequencies.Add(currentFrequency);
            }

            return deletions;
        }
    }
}