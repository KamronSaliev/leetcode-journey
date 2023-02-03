namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/valid-anagram/
    /// </summary>
    public class Easy242_ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var counts = new int[26];

            for (var i = 0; i < s.Length; i++)
            {
                counts[s[i] - 'a']++;
                counts[t[i] - 'a']--;
            }

            for (var i = 0; i < counts.Length; i++)
            {
                if (counts[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}