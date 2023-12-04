using System;
using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-value-of-k-coins-from-piles/
    /// </summary>
    public class Hard2218_MaximumValueOfKCoinsFromPiles
    {
        public int MaxValueOfCoins(IList<IList<int>> piles, int k)
        {
            var n = piles.Count;
            var dp = new int[n, k + 1];

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j <= k; j++)
                {
                    dp[i, j] = -1;
                }
            }

            return MaxValueOfCoinsHelper(piles, 0, k, dp);
        }

        private int MaxValueOfCoinsHelper(IList<IList<int>> piles, int pileIndex, int k, int[,] dp)
        {
            if (pileIndex >= piles.Count || k <= 0)
            {
                return 0;
            }

            if (dp[pileIndex, k] != -1)
            {
                return dp[pileIndex, k];
            }

            dp[pileIndex, k] = MaxValueOfCoinsHelper(piles, pileIndex + 1, k, dp);
            var prefixSum = 0;

            for (var i = 0; i < piles[pileIndex].Count && i < k; i++)
            {
                prefixSum += piles[pileIndex][i];

                dp[pileIndex, k] = Math.Max(dp[pileIndex, k],
                    prefixSum + MaxValueOfCoinsHelper(piles, pileIndex + 1, k - i - 1, dp));
            }

            return dp[pileIndex, k];
        }
    }
}