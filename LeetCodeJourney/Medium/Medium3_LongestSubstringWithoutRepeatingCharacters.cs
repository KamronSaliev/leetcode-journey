using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    public class Medium3_LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var characters = new HashSet<char>();
            var tempString = new Queue<char>();
            var maxLength = 0;

            for (var i = 0; i < s.Length; i++)
            {
                while (tempString.Count > 0 && characters.Contains(s[i]))
                {
                    characters.Remove(tempString.Dequeue());
                }

                characters.Add(s[i]);
                tempString.Enqueue(s[i]);
                maxLength = tempString.Count > maxLength ? tempString.Count : maxLength;
            }

            return maxLength;
        }
    }
}