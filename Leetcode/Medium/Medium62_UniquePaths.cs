namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/unique-paths/
    /// </summary>
    public class Medium62_UniquePaths
    {
        public int UniquePaths(int m, int n)
        {
            var dp = new int[m, n];
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 1;
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                    }
                }
            }

            return dp[m - 1, n - 1];
        }
    }
}