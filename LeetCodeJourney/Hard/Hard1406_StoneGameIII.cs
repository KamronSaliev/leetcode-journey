using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/stone-game-iii/
    /// </summary>
    public class Hard1406_StoneGameIII
    {
        public string StoneGameIII(int[] stoneValue)
        {
            var n = stoneValue.Length;
            var dp = new int[3];

            for (var i = n - 1; i >= 0; i--)
            {
                var take1 = stoneValue[i] - dp[(i + 1) % 3];

                var take2 = int.MinValue;
                if (i + 1 < n)
                {
                    take2 = stoneValue[i] + stoneValue[i + 1] - dp[(i + 2) % 3];
                }

                var take3 = int.MinValue;
                if (i + 2 < n)
                {
                    take3 = stoneValue[i] + stoneValue[i + 1] + stoneValue[i + 2] - dp[(i + 3) % 3];
                }

                dp[i % 3] = Math.Max(take1, Math.Max(take2, take3));
            }

            return dp[0] switch
            {
                > 0 => "Alice",
                < 0 => "Bob",
                _ => "Tie"
            };
        }
    }
}