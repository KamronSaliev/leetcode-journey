namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/n-th-tribonacci-number/
    /// </summary>
    public class Easy1137_N_thTribonacciNumber
    {
        public int Tribonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            var dp = new int[n + 1];

            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
            }

            return dp[^1];
        }
    }
}