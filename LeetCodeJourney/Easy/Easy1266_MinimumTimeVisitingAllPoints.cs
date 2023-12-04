using System;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-time-visiting-all-points/
    /// </summary>
    public class Easy1266_MinimumTimeVisitingAllPoints
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            var result = 0;

            for (var i = 0; i < points.Length - 1; i++)
            {
                result += Math.Max
                (
                    Math.Abs(points[i + 1][0] - points[i][0]),
                    Math.Abs(points[i + 1][1] - points[i][1])
                );
            }

            return result;
        }
    }
}