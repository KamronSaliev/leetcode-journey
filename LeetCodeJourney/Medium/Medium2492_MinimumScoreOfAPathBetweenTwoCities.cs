using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-score-of-a-path-between-two-cities/
    /// </summary>
    public class Medium2492_MinimumScoreOfAPathBetweenTwoCities
    {
        public int MinScore(int n, int[][] roads)
        {
            var graph = Enumerable
                .Range(1, n)
                .ToDictionary(key => key, _ => new List<(int to, int length)>());

            foreach (var road in roads)
            {
                graph[road[0]].Add((road[1], road[2]));
                graph[road[1]].Add((road[0], road[2]));
            }

            var queue = new Queue<int>();
            var visited = new HashSet<int> { 1 };

            queue.Enqueue(1);

            var result = int.MaxValue;

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();

                foreach (var road in graph[current])
                {
                    result = Math.Min(result, road.length);

                    if (visited.Add(road.to))
                    {
                        queue.Enqueue(road.to);
                    }
                }
            }

            return result;
        }
    }
}