namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/count-ways-to-build-good-strings/
    /// </summary>
    public class Medium2466_CountWaysToBuildGoodStrings
    {
        public int CountGoodStrings(int low, int high, int zero, int one)
        {
            var dp = new int[high + 1];
            var mod = (int)1e9 + 7;
            var result = 0;

            dp[0] = 1;

            for (var i = 1; i <= high; i++)
            {
                if (i >= zero)
                {
                    dp[i] = (dp[i] + dp[i - zero]) % mod;
                }

                if (i >= one)
                {
                    dp[i] = (dp[i] + dp[i - one]) % mod;
                }

                if (i >= low)
                {
                    result = (result + dp[i]) % mod;
                }
            }

            return result;
        }
    }
}