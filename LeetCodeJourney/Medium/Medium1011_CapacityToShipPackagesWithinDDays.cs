using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/
    /// </summary>
    public class Medium1011_CapacityToShipPackagesWithinDDays
    {
        public int ShipWithinDays(int[] weights, int days)
        {
            var maxLoad = 0;
            var totalLoad = 0;

            for (var i = 0; i < weights.Length; i++)
            {
                maxLoad = Math.Max(maxLoad, weights[i]);
                totalLoad += weights[i];
            }

            var left = maxLoad;
            var right = totalLoad;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (CanBeShipped(weights, days, mid))
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        private bool CanBeShipped(int[] weights, int days, int capacity)
        {
            var sum = 0;
            var count = 1;

            for (var i = 0; i < weights.Length; i++)
            {
                if (sum + weights[i] > capacity)
                {
                    sum = 0;
                    count++;
                }

                sum += weights[i];
            }

            return count <= days;
        }
    }
}