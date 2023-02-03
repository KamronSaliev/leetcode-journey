using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class Easy9_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            var number = x;
            var list = new List<int>();

            if (number < 0)
            {
                return false;
            }

            while (number != 0)
            {
                var remainder = number % 10;
                list.Add(remainder);
                number /= 10;
            }

            for (var i = 0; i < list.Count / 2; i++)
            {
                if (list[i] != list[list.Count - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}