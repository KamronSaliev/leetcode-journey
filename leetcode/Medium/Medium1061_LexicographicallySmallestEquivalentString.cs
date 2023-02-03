using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/lexicographically-smallest-equivalent-string/
    /// </summary>
    public class Medium1061_LexicographicallySmallestEquivalentString
    {
        public string SmallestEquivalentString(string s1, string s2, string baseStr)
        {
            var parent = new int[26];
            Array.Fill(parent, -1);
            
            for (var i = 0; i < s1.Length; i++)
            {
                Union(s1[i] - 'a', s2[i] - 'a', parent);
            }

            var result = string.Empty;
            for (var i = 0; i < baseStr.Length; i++)
            {
                var ch = (char)('a' + Find(baseStr[i] - 'a', parent));
                result += ch;
            }

            return result;
        }

        private int Find(int character, int[] parent)
        {
            if (parent[character] == -1)
            {
                return character;
            }

            return parent[character] = Find(parent[character], parent);
        }

        private void Union(int character1, int character2, int[] parent)
        {
            var p1 = Find(character1, parent);
            var p2 = Find(character2, parent);

            if (p1 != p2)
            {
                parent[Math.Max(p1, p2)] = Math.Min(p1, p2);
            }
        }
    }
}