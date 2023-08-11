namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/coin-change-ii/
    /// </summary>
    public class Medium518_CoinChangeII
    {
        public int Change(int amount, int[] coins)
        {
            var dp = new int[amount + 1];
            dp[0] = 1;

            foreach (var coin in coins)
            {
                for (var j = coin; j <= amount; j++)
                {
                    dp[j] += dp[j - coin];
                }
            }

            return dp[amount];
        }
    }
}