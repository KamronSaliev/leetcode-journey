using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/reorganize-string/
    /// </summary>
    public class Medium767_ReorganizeString
    {
        public string ReorganizeString(string s)
        {
            var frequencies = new Dictionary<char, int>();

            foreach (var character in s)
            {
                frequencies.TryAdd(character, 0);
                frequencies[character]++;
            }

            var sortedCharacters = new List<char>(frequencies.Keys);
            sortedCharacters.Sort((a, b) => frequencies[b].CompareTo(frequencies[a]));

            if (frequencies[sortedCharacters[0]] > (s.Length + 1) / 2)
            {
                return "";
            }

            var result = new char[s.Length];
            var i = 0;

            foreach (var c in sortedCharacters)
            {
                for (var j = 0; j < frequencies[c]; j++)
                {
                    if (i >= s.Length)
                    {
                        i = 1;
                    }

                    result[i] = c;
                    i += 2;
                }
            }

            return new string(result);
        }
    }
}