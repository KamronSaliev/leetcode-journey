using System.Collections.Generic;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-all-anagrams-in-a-string/
    /// </summary>
    public class Medium438_FindAllAnagramsInAString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            if (p.Length > s.Length)
            {
                return new List<int>();
            }

            var result = new List<int>();

            var map = new int[26];
            
            for (int i = 0; i < p.Length; i++)
            {
                map[p[i] - 'a']++;
            }
            
            for (int i = 0; i < p.Length; i++)
            {
                map[s[i] - 'a']--;
            }

            for (int i = p.Length; i < s.Length; i++)
            {
                if (IsAnagram(map))
                {
                    result.Add(i - p.Length);
                }

                map[s[i - p.Length] - 'a']++;
                map[s[i] - 'a']--;
            }

            if (IsAnagram(map))
            {
                result.Add(s.Length - p.Length);
            }

            return result;
        }

        private bool IsAnagram(int[] map)
        {
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}