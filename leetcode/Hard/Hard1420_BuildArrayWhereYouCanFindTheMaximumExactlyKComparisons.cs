namespace LeetCode.Hard
{
    public class Hard1420_BuildArrayWhereYouCanFindTheMaximumExactlyKComparisons
    {
        public int NumOfArrays(int n, int m, int k)
        {
            const int mod = (int)(1e9 + 7);

            var dp = new int[n + 1][][];
            var prefix = new int[n + 1][][];

            for (var i = 0; i <= n; i++)
            {
                dp[i] = new int[m + 1][];
                prefix[i] = new int[m + 1][];

                for (var j = 0; j <= m; j++)
                {
                    dp[i][j] = new int[k + 1];
                    prefix[i][j] = new int[k + 1];
                }
            }

            for (var j = 1; j <= m; j++)
            {
                dp[1][j][1] = 1;
                prefix[1][j][1] = j;
            }

            for (var i = 2; i <= n; i++)
            {
                for (var j = 1; j <= m; j++)
                {
                    for (var l = 1; l <= k; l++)
                    {
                        dp[i][j][l] = (int)(1L * j * dp[i - 1][j][l] % mod);

                        if (j > 1 && l > 1)
                        {
                            dp[i][j][l] = (dp[i][j][l] + prefix[i - 1][j - 1][l - 1]) % mod;
                        }

                        prefix[i][j][l] = (prefix[i][j - 1][l] + dp[i][j][l]) % mod;
                    }
                }
            }

            return prefix[n][m][k];
        }
    }
}