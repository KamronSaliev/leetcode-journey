using System;
using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-cycle-in-a-graph/
    /// </summary>
    public class Hard2360_LongestCycleInAGraph
    {
        public int LongestCycle(int[] edges)
        {
            var max = -1;
            var visited = new bool[edges.Length];

            for (var i = 0; i < edges.Length; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                var d = new Dictionary<int, int>();
                var distance = 0;

                for (var j = i; j != -1; j = edges[j])
                {
                    if (d.TryGetValue(j, out var value))
                    {
                        max = Math.Max(max, distance - value);
                    }

                    if (visited[j])
                    {
                        break;
                    }

                    visited[j] = true;
                    d[j] = distance;
                    distance++;
                }
            }

            return max;
        }
    }
}