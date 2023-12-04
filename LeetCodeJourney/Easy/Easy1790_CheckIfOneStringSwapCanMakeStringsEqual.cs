using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal/
    /// </summary>
    public class Easy1790_CheckIfOneStringSwapCanMakeStringsEqual
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            var array1 = new int[26];
            var array2 = new int[26];
            var counter = 0;

            for (var i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    counter++;
                }

                Console.WriteLine(counter);

                if (counter > 2)
                {
                    return false;
                }

                array1[s1[i] - 'a']++;
                array2[s2[i] - 'a']++;
            }

            for (var i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}