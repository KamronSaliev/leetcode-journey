using System;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-ice-cream-bars/
    /// </summary>
    public class Medium1833_MaximumIceCreamBars
    {
        public int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs);

            var counter = 0;

            for (var i = 0; i < costs.Length; i++)
            {
                if (costs[i] > coins)
                {
                    return counter;
                }

                coins -= costs[i];
                counter++;
            }

            return counter;
        }
    }
}