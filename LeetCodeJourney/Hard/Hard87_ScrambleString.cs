namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/scramble-string/
    /// </summary>
    public class Hard87_ScrambleString
    {
        public bool IsScramble(string s1, string s2)
        {
            var n = s1.Length;
            var dp = new bool[n + 1][][];

            for (var i = 0; i < dp.Length; ++i)
            {
                dp[i] = new bool[n][];

                for (var j = 0; j < dp[i].Length; ++j)
                {
                    dp[i][j] = new bool[n];
                }
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    dp[1][i][j] = s1[i] == s2[j];
                }
            }

            for (var length = 2; length <= n; length++)
            {
                for (var i = 0; i < n + 1 - length; i++)
                {
                    for (var j = 0; j < n + 1 - length; j++)
                    {
                        for (var newLength = 1; newLength < length; newLength++)
                        {
                            var dp1 = dp[newLength][i];
                            var dp2 = dp[length - newLength][i + newLength];
                            dp[length][i][j] |= dp1[j] && dp2[j + newLength];
                            dp[length][i][j] |= dp1[j + length - newLength] && dp2[j];
                        }
                    }
                }
            }

            return dp[n][0][0];
        }
    }
}