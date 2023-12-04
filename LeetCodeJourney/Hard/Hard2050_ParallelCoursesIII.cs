using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/parallel-courses-iii/
    ///     https://leetcode.com/problems/parallel-courses-iii/solutions/4180326/92-65-bfs-in-directed-acyclic-graph/?envType=daily-question
    ///     &amp;envId=2023-10-18
    /// </summary>
    public class Hard2050_ParallelCoursesIII
    {
        public int MinimumTime(int n, int[][] relations, int[] time)
        {
            var graph = new Dictionary<int, List<int>>();
            var inDegree = new int[n + 1];

            foreach (var relation in relations)
            {
                if (!graph.ContainsKey(relation[0]))
                {
                    graph[relation[0]] = new List<int>();
                }

                graph[relation[0]].Add(relation[1]);
                inDegree[relation[1]]++;
            }

            var dist = new int[n + 1];
            Array.Copy(time, 0, dist, 1, n);
            var queue = new Queue<int>();

            for (var i = 1; i <= n; i++)
            {
                if (inDegree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();

                if (!graph.TryGetValue(current, out var value))
                {
                    continue;
                }

                foreach (var nextCourse in value)
                {
                    dist[nextCourse] = Math.Max(dist[nextCourse], dist[current] + time[nextCourse - 1]);
                    inDegree[nextCourse]--;

                    if (inDegree[nextCourse] == 0)
                    {
                        queue.Enqueue(nextCourse);
                    }
                }
            }

            return dist.Max();
        }
    }
}