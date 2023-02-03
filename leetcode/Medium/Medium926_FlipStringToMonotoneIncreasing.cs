using System;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/flip-string-to-monotone-increasing/
    ///     https://leetcode.com/problems/flip-string-to-monotone-increasing/solutions/2912351/flip-string-to-monotone-increasing/?orderBy=most_votes
    /// </summary>
    public class Medium926_FlipStringToMonotoneIncreasing
    {
        public int MinFlipsMonoIncr(string s)
        {
            var ans = 0;
            var num = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    ans = Math.Min(num, ans + 1);
                }
                else
                {
                    num++;
                }
            }

            return ans;
        }
    }
}