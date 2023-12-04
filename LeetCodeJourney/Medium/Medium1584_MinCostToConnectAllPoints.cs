using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/min-cost-to-connect-all-points/
    /// </summary>
    public class Medium1584_MinCostToConnectAllPoints
    {
        public int MinCostConnectPoints(int[][] points)
        {
            var n = points.Length;
            var visited = new bool[n];
            var dictionary = new Dictionary<int, int> { { 0, 0 } };
            var minHeap = new SortedSet<(int w, int u)> { (0, 0) };
            var mstWeight = 0;

            while (minHeap.Count > 0)
            {
                var (w, u) = minHeap.Min;
                minHeap.Remove(minHeap.Min);

                if (visited[u] || dictionary[u] < w)
                {
                    continue;
                }

                visited[u] = true;
                mstWeight += w;

                for (var v = 0; v < n; v++)
                {
                    if (!visited[v])
                    {
                        var newDistance = ManhattanDistance(points[u], points[v]);
                        if (newDistance < dictionary.GetValueOrDefault(v, int.MaxValue))
                        {
                            dictionary[v] = newDistance;
                            minHeap.Add((newDistance, v));
                        }
                    }
                }
            }

            return mstWeight;
        }

        private int ManhattanDistance(int[] p1, int[] p2)
        {
            return Math.Abs(p1[0] - p2[0]) + Math.Abs(p1[1] - p2[1]);
        }
    }
}