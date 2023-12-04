using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/determine-if-a-cell-is-reachable-at-a-given-time/
    /// </summary>
    public class Medium2849_DetermineIfACellIsReachableAtAGivenTime
    {
        public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
        {
            if (sx == fx && sy == fy && t == 1)
            {
                return false;
            }

            var differenceX = Math.Abs(fx - sx);
            var differenceY = Math.Abs(fy - sy);
            var maxDifference = Math.Max(differenceX, differenceY);
            return maxDifference <= t;
        }
    }
}