using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/eliminate-maximum-number-of-monsters/
    /// </summary>
    public class Medium1921_EliminateMaximumNumberOfMonsters
    {
        public int EliminateMaximum(int[] dist, int[] speed)
        {
            var n = dist.Length;
            var timeToReachCity = new double[n];

            for (var i = 0; i < n; i++)
            {
                timeToReachCity[i] = (double)dist[i] / speed[i];
            }

            Array.Sort(timeToReachCity);

            for (var i = 0; i < n; i++)
            {
                if (timeToReachCity[i] <= i)
                {
                    return i;
                }
            }

            return n;
        }
    }
}