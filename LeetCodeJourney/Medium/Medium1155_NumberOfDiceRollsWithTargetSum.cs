namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-dice-rolls-with-target-sum/
    /// </summary>
    public class Medium1155_NumberOfDiceRollsWithTargetSum
    {
        public int NumRollsToTarget(int n, int k, int target)
        {
            const int mod = (int)1e9 + 7;

            var dp = new int[target + 1];
            dp[0] = 1;

            for (var i = 1; i <= n; i++)
            {
                var current = new int[dp.Length];

                for (var j = 1; j <= target; j++)
                {
                    if (j > i * k)
                    {
                        continue;
                    }

                    for (var m = 1; m <= k && m <= j; m++)
                    {
                        current[j] = (current[j] + dp[j - m]) % mod;
                    }
                }

                dp = current;
            }

            return dp[target];
        }
    }
}