namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/climbing-stairs/
    /// </summary>
    public class Easy70_ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            var dp = new int[n + 1];

            dp[0] = 1;
            dp[1] = 1;

            for (var i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[^1];
        }
    }
}