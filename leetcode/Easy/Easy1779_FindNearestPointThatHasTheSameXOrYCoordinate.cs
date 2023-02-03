using System;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/find-nearest-point-that-has-the-same-x-or-y-coordinate/
    /// </summary>
    public class Easy1779_FindNearestPointThatHasTheSameXOrYCoordinate
    {
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            var min = (int)1e9;
            var ans = -1;

            for (int i = 0; i < points.Length; i++)
            {
                if (x == points[i][0] || y == points[i][1])
                {
                    var manhattanDistance = Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]);

                    if (manhattanDistance < min)
                    {
                        min = manhattanDistance;
                        ans = i;
                    }
                }
            }

            return ans;
        }
    }
}