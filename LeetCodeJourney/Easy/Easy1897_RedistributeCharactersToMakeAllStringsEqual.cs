using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/redistribute-characters-to-make-all-strings-equal/
    /// </summary>
    public class Easy1897_RedistributeCharactersToMakeAllStringsEqual
    {
        public bool MakeEqual(string[] words)
        {
            var occurrences = new Dictionary<char, int>();

            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    if (occurrences.TryGetValue(character, out var count))
                    {
                        occurrences[character] = count + 1;
                    }
                    else
                    {
                        occurrences.Add(character, 1);
                    }
                }
            }

            return occurrences.Values.All(value => value % words.Length == 0);
        }
    }
}