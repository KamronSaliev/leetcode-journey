namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/interleaving-string/
    /// </summary>
    public class Medium97_InterleavingString
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            var m = s1.Length;
            var n = s2.Length;
            var l = s3.Length;

            if (m + n != l)
            {
                return false;
            }

            var dp = new bool[n + 1];
            dp[0] = true;

            for (var j = 1; j <= n; ++j)
            {
                dp[j] = dp[j - 1] && s2[j - 1] == s3[j - 1];
            }

            for (var i = 1; i <= m; ++i)
            {
                dp[0] = dp[0] && s1[i - 1] == s3[i - 1];

                for (var j = 1; j <= n; ++j)
                {
                    dp[j] = (dp[j] && s1[i - 1] == s3[i + j - 1]) || (dp[j - 1] && s2[j - 1] == s3[i + j - 1]);
                }
            }

            return dp[n];
        }
    }
}