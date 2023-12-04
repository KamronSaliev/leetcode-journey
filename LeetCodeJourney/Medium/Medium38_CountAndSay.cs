using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/count-and-say/
    /// </summary>
    public class Medium38_CountAndSay
    {
        public string CountAndSay(int n, string s = "1")
        {
            if (n == 1)
            {
                return s;
            }

            var i = 0;
            int j;
            var len = s.Length;
            var res = "";

            while (i < len)
            {
                j = i;

                while (i < len && s[i] == s[j])
                {
                    i++;
                }

                res += Convert.ToString(i - j) + s[j];
            }

            return CountAndSay(n - 1, res);
        }
    }
}