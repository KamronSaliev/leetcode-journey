using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/profitable-schemes/
    /// </summary>
    public class Hard879_ProfitableSchemes
    {
        public int ProfitableSchemes(int n, int minProfit, int[] group, int[] profit)
        {
            var dp = new int[minProfit + 1, n + 1];
            dp[0, 0] = 1;
            
            for (var k = 0; k < group.Length; k++)
            {
                var g = group[k];
                var p = profit[k];
                
                for (var i = minProfit; i >= 0; i--)
                {
                    for (var j = n - g; j >= 0; j--)
                    {
                        dp[Math.Min(i + p, minProfit), j + g] += dp[i, j];
                        dp[Math.Min(i + p, minProfit), j + g] %= (int)(1e9 + 7);
                    }
                }
            }

            var sum = 0;
            
            for (var j = 0; j <= n; j++)
            {
                sum = (sum + dp[minProfit, j]) % (int)(1e9 + 7);
            }

            return sum;
        }
    }
}