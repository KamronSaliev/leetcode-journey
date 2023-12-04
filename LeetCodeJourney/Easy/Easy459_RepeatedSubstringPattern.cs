using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/repeated-substring-pattern/
    /// </summary>
    public class Easy459_RepeatedSubstringPattern
    {
        public bool RepeatedSubstringPattern(string s)
        {
            var n = s.Length;

            for (var i = 1; i <= n / 2; i++)
            {
                if (n % i != 0)
                {
                    continue;
                }

                var builder = new StringBuilder();

                for (var j = 0; j < n / i; j++)
                {
                    builder.Append(s[..i]);
                }

                if (builder.ToString() == s)
                {
                    return true;
                }
            }

            return false;
        }
    }
}