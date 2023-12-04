using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/stone-game-ii/
    /// </summary>
    public class Medium1140_StoneGameII
    {
        public int StoneGameII(int[] piles)
        {
            var n = piles.Length;

            if (n <= 2)
            {
                return n;
            }

            var prefixSum = new int[n];
            prefixSum[n - 1] = piles[n - 1];

            for (var i = n - 2; i >= 0; i--)
            {
                prefixSum[i] = prefixSum[i + 1] + piles[i];
            }

            var dp = new int [n, n];

            PlayGame(dp, prefixSum, 0, 1, n);

            return dp[0, 1];
        }

        private int PlayGame(int[,] dp, int[] prefixSum, int index, int m, int n)
        {
            if (index >= n)
            {
                return 0;
            }

            if (index + 2 * m >= n)
            {
                return prefixSum[index];
            }

            if (dp[index, m] != 0)
            {
                return dp[index, m];
            }

            var result = int.MaxValue;

            for (var i = 1; i <= 2 * m; i++)
            {
                result = Math.Min(result, PlayGame(dp, prefixSum, index + i, Math.Max(m, i), n));
            }

            dp[index, m] = prefixSum[index] - result;

            return dp[index, m];
        }
    }
}