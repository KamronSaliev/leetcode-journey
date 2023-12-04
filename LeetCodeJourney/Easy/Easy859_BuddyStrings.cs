using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/buddy-strings/
    /// </summary>
    public class Easy859_BuddyStrings
    {
        public bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length)
            {
                return false;
            }

            if (s == goal)
            {
                var uniqueCharacters = new HashSet<char>();
                foreach (var character in s)
                {
                    uniqueCharacters.Add(character);
                }

                return uniqueCharacters.Count < s.Length;
            }

            var diffIndices = new List<int>();
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] != goal[i])
                {
                    diffIndices.Add(i);
                }
            }

            return diffIndices.Count == 2 &&
                   s[diffIndices[0]] == goal[diffIndices[1]] &&
                   s[diffIndices[1]] == goal[diffIndices[0]];
        }
    }
}