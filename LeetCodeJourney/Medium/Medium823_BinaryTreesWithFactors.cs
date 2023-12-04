using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/binary-trees-with-factors/
    /// </summary>
    public class Medium823_BinaryTreesWithFactors
    {
        private const int Mod = (int)1e9 + 7;

        public int NumFactoredBinaryTrees(int[] arr)
        {
            Array.Sort(arr);

            var unique = new HashSet<int>(arr);
            var dp = new Dictionary<int, long>();

            foreach (var i in arr)
            {
                dp[i] = 1;
            }

            foreach (var i in arr)
            {
                foreach (var j in arr)
                {
                    if (j > Math.Sqrt(i))
                    {
                        break;
                    }

                    if (i % j != 0 || !unique.Contains(i / j))
                    {
                        continue;
                    }

                    var temp = dp[j] * dp[i / j];
                    dp[i] = (dp[i] + (i / j == j ? temp : temp * 2)) % Mod;
                }
            }

            var result = 0L;
            foreach (var value in dp.Values)
            {
                result = (result + value) % Mod;
            }

            return (int)result;
        }
    }
}