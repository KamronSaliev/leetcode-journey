using System;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/
    /// </summary>
    public class Medium452_MinimumNumberOfArrowsToBurstBalloons
    {
        public int FindMinArrowShots(int[][] points)
        {
            Array.Sort(points, (x, y) => x[1].CompareTo(y[1]));
            
            var end = points[0][1];
            var counter = 1;
            
            for (var i = 1; i < points.Length; i++)
            {
                if (end >= points[i][0])
                {
                    continue;
                }

                counter++;
                end = points[i][1];
            }

            return counter;
        }
    }
}