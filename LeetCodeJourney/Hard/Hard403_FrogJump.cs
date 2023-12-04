using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/frog-jump/
    /// </summary>
    public class Hard403_FrogJump
    {
        public bool CanCross(int[] stones)
        {
            var dp = new Dictionary<int, HashSet<int>>();
            var n = stones.Length;

            foreach (var stone in stones)
            {
                dp[stone] = new HashSet<int>();
            }

            dp[0].Add(0);

            for (var i = 0; i < n; i++)
            {
                foreach (var k in dp[stones[i]])
                {
                    for (var step = k - 1; step <= k + 1; step++)
                    {
                        if (step != 0 && dp.ContainsKey(stones[i] + step))
                        {
                            dp[stones[i] + step].Add(step);
                        }
                    }
                }
            }

            return dp[stones[n - 1]].Count > 0;
        }
    }
}