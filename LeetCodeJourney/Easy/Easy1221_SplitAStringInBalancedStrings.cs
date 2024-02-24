namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/split-a-string-in-balanced-strings/
    /// </summary>
    public class Easy1221_SplitAStringInBalancedStrings
    {
        public int BalancedStringSplit(string s)
        {
            var result = 0;
            var r = 0;
            var l = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                {
                    r++;
                }
                else
                {
                    l++;
                }

                if (r != l)
                {
                    continue;
                }

                result++;
                r = 0;
                l = 0;
            }

            return result;
        }
    }
}