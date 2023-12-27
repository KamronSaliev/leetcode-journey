using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-time-to-make-rope-colorful/
    /// </summary>
    public class Medium1578_MinimumTimeToMakeRopeColorful
    {
        public int MinCost(string colors, int[] neededTime)
        {
            var n = colors.Length;
            var previousColor = ' ';
            var previousTime = 0;
            var previousCost = 0;

            for (var i = 0; i < n; i++)
            {
                int currentCost;
                
                if (colors[i] == previousColor)
                {
                    var currentMinTime = Math.Min(neededTime[i], previousTime);
                    currentCost = currentMinTime + previousCost;
                    previousTime = Math.Max(neededTime[i], previousTime);
                }
                else
                {
                    currentCost = previousCost;
                    previousColor = colors[i];
                    previousTime = neededTime[i];
                }

                previousCost = currentCost;
            }

            return previousCost;
        }
    }
}