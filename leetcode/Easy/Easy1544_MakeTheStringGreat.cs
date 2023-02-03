using System;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/make-the-string-great/
    /// </summary>
    public class Easy1544_MakeTheStringGreat
    {
        public string MakeGood(string s)
        {
            for (var i = 1; i < s.Length; i++)
            {
                if (Math.Abs(s[i] - s[i - 1]) != 32)
                {
                    continue;
                }

                s = s.Remove(i - 1, 2);
                i = Math.Max(0, i - 2);
            }

            return s;
        }
    }
}