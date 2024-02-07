using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/sort-characters-by-frequency/
    /// </summary>
    public class Medium451_SortCharactersByFrequency
    {
        public string FrequencySort(string s)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var character in s)
            {
                if (!dictionary.TryAdd(character, 1))
                {
                    dictionary[character] += 1;
                }
            }

            var keys = dictionary.ToArray();
            Array.Sort(keys, (x, y) => y.Value - x.Value);

            var stringBuilder = new StringBuilder();

            foreach (var key in keys)
            {
                stringBuilder.Append(key.Key, key.Value);
            }

            return stringBuilder.ToString();
        }
    }
}