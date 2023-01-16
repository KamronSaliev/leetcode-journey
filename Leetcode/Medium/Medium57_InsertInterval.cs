using System;
using System.Collections.Generic;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/insert-interval/
    /// </summary>
    public class Medium57_InsertInterval
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var res = new List<int[]>();

            foreach (var interval in intervals)
            {
                if (interval[0] > newInterval[1])
                {
                    res.Add(newInterval);
                    newInterval = interval;
                }
                else if (interval[1] < newInterval[0])
                {
                    res.Add(interval);
                }
                else
                {
                    newInterval[0] = Math.Min(newInterval[0], interval[0]);
                    newInterval[1] = Math.Max(newInterval[1], interval[1]);
                }
            }

            res.Add(newInterval);

            return res.ToArray();
        }
    }
}