using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-cost-for-tickets/
    /// </summary>
    public class Medium983_MinimumCostForTickets
    {
        public int MincostTickets(int[] days, int[] costs)
        {
            var includedDays = new bool[366];
            for (var i = 0; i < days.Length; i++)
            {
                includedDays[days[i]] = true;
            }

            var minCost = new int[366];
            for (var i = 1; i <= 365; i++)
            {
                if (!includedDays[i])
                {
                    minCost[i] = minCost[i - 1];
                    continue;
                }

                var min = minCost[i - 1] + costs[0];
                min = Math.Min(min, minCost[Math.Max(0, i - 7)] + costs[1]);
                min = Math.Min(min, minCost[Math.Max(0, i - 30)] + costs[2]);
                minCost[i] = min;
            }

            return minCost[365];
        }
    }
}