using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/find-the-highest-altitude/
    /// </summary>
    public class Easy1732_FindTheHighestAltitude
    {
        public int LargestAltitude(int[] gain)
        {
            var currentAltitude = 0;
            var maxAltitude = 0;

            for (var i = 0; i < gain.Length; i++)
            {
                currentAltitude += gain[i];
                maxAltitude = Math.Max(maxAltitude, currentAltitude);
            }

            return maxAltitude;
        }
    }
}