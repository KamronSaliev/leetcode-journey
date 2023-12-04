using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/non-overlapping-intervals/
    /// </summary>
    public class Medium435_NonOverlappingIntervals
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

            var count = 0;
            var end = intervals[0][1];

            for (var i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] < end)
                {
                    count++;
                }
                else
                {
                    end = intervals[i][1];
                }
            }

            return count;
        }
    }
}