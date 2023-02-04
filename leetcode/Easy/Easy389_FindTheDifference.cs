using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/find-the-difference/
    /// </summary>
    public class Easy389_FindTheDifference
    {
        public char FindTheDifference(string s, string t)
        {
            var array = new int[26];

            for (var i = 0; i < s.Length; i++)
            {
                array[s[i] - 'a']++;
            }

            for (var i = 0; i < t.Length; i++)
            {
                array[t[i] - 'a']++;
            }

            Console.WriteLine(string.Join(" ", array));

            var addedLetter = 'a';

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    addedLetter = (char)(i + 'a');
                    break;
                }
            }

            return addedLetter;
        }
    }
}