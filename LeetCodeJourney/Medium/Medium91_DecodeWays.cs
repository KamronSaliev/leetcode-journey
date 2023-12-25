namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/decode-ways/
    /// </summary>
    public class Medium91_DecodeWays
    {
        public int NumDecodings(string s)
        {
            if (s[0] == '0')
            {
                return 0;
            }

            var n = s.Length;
            var dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (var i = 2; i <= n; i++)
            {
                var oneDigit = s[i - 1] - '0';
                var twoDigits = (s[i - 2] - '0') * 10 + oneDigit;

                if (oneDigit >= 1)
                {
                    dp[i] += dp[i - 1];
                }

                if (twoDigits is >= 10 and <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }

            return dp[n];
        }
    }
}