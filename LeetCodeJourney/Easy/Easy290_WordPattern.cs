using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/word-pattern/
    /// </summary>
    public class Easy290_WordPattern
    {
        public bool WordPattern(string pattern, string s)
        {
            var words = s.Split(' ');
            var dict1 = new Dictionary<char, string>();
            var dict2 = new Dictionary<string, char>();

            if (words.Length != pattern.Length)
            {
                return false;
            }
            
            for (var i = 0; i < words.Length; i++)
            {
                dict1.TryAdd(pattern[i], words[i]);
                dict2.TryAdd(words[i], pattern[i]);

                if (dict1[pattern[i]] != words[i] || dict2[words[i]] != pattern[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}