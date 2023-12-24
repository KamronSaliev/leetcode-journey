using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-changes-to-make-alternating-binary-string/
    /// </summary>
    public class Easy1758_MinimumChangesToMakeAlternatingBinaryString
    {
        public int MinOperations(string s)
        {
            var count0 = 0;
            var count1 = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if ((s[i] == '0' && i % 2 == 0) || (s[i] == '1' && i % 2 != 0))
                {
                    count1++;
                }
                else
                {
                    count0++;
                }
            }

            return Math.Min(count0, count1);
        }
    }
}