using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-amount-of-time-to-collect-garbage/
    /// </summary>
    public class Medium2391_MinimumAmountOfTimeToCollectGarbage
    {
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            var prefixSum = new int[travel.Length + 1];
            prefixSum[1] = travel[0];

            for (var i = 1; i < travel.Length; i++)
            {
                prefixSum[i + 1] = prefixSum[i] + travel[i];
            }

            var garbageLastPosition = new Dictionary<char, int>();
            var garbageCount = new Dictionary<char, int>();

            for (var i = 0; i < garbage.Length; i++)
            {
                foreach (var c in garbage[i])
                {
                    garbageLastPosition[c] = i;
                    if (!garbageCount.TryAdd(c, 1))
                    {
                        garbageCount[c]++;
                    }
                }
            }

            var garbageTypes = "MPG";
            var result = 0;

            foreach (var c in garbageTypes)
            {
                if (garbageCount.TryGetValue(c, out var value))
                {
                    result += prefixSum[garbageLastPosition[c]] + value;
                }
            }

            return result;
        }
    }
}