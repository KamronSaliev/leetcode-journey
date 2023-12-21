using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/widest-vertical-area-between-two-points-containing-no-points/
    /// </summary>
    public class Medium1637_WidestVerticalAreaBetweenTwoPointsContainingNoPoints
    {
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));

            var result = 0;

            for (var i = 1; i < points.Length; i++)
            {
                var width = points[i][0] - points[i - 1][0];
                result = Math.Max(result, width);
            }

            return result;
        }
    }
}