using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/assign-cookies/
    /// </summary>
    public class Easy455_AssignCookies
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            var childIndex = g.Length - 1;
            var cookieIndex = s.Length - 1;
            var result = 0;

            while (childIndex >= 0 && cookieIndex >= 0)
            {
                if (s[cookieIndex] >= g[childIndex])
                {
                    childIndex--;
                    cookieIndex--;
                    result++;
                }
                else
                {
                    childIndex--;
                }
            }

            return result;
        }
    }
}