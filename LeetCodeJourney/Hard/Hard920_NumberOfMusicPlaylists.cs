using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-music-playlists/
    ///     https://leetcode.com/problems/number-of-music-playlists/solutions/3869510/o-n-goal-dynamic-programming-creating-unique-music-playlists/
    /// </summary>
    public class Hard920_NumberOfMusicPlaylists
    {
        public int NumMusicPlaylists(int n, int goal, int k)
        {
            var mod = (int)1e9 + 7;
            var dp = new long[2][];

            for (var i = 0; i < 2; i++)
            {
                dp[i] = new long[n + 1];
            }

            dp[0][0] = 1;

            for (var i = 1; i <= goal; i++)
            {
                dp[i % 2][0] = 0;

                for (var j = 1; j <= Math.Min(i, n); j++)
                {
                    dp[i % 2][j] = dp[(i - 1) % 2][j - 1] * (n - (j - 1)) % mod;

                    if (j > k)
                    {
                        dp[i % 2][j] = (dp[i % 2][j] + dp[(i - 1) % 2][j] * (j - k)) % mod;
                    }
                }
            }

            return (int)dp[goal % 2][n];
        }
    }
}