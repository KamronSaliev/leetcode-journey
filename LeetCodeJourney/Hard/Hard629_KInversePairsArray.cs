namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/k-inverse-pairs-array/
    /// </summary>
    public class Hard629_KInversePairsArray
    {
        private const int Mod = (int)1e9 + 7;

        public int KInversePairs(int n, int k)
        {
            var dp = new int[k + 1];
            dp[0] = 1;

            for (var i = 2; i <= n; i++)
            {
                for (var j = 1; j <= k; j++)
                {
                    dp[j] = (dp[j] + dp[j - 1]) % Mod;
                }

                for (var j = k; j >= i; j--)
                {
                    dp[j] = (dp[j] - dp[j - i] + Mod) % Mod;
                }
            }

            return dp[k];
        }
    }
}