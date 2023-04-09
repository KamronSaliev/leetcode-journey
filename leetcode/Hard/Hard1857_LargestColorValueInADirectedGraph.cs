using System;
using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/largest-color-value-in-a-directed-graph/
    /// </summary>
    public class Hard1857_LargestColorValueInADirectedGraph
    {
        public int LargestPathValue(string colors, int[][] edges)
        {
            var n = colors.Length;
            var adjList = new List<int>[n];
            var indegree = new int[n];

            for (var i = 0; i < n; i++)
            {
                adjList[i] = new List<int>();
            }

            foreach (var edge in edges)
            {
                adjList[edge[0]].Add(edge[1]);
                indegree[edge[1]]++;
            }

            var memo = new int[n, 26];
            var maxColorValue = -1;
            var queue = new Queue<int>();

            for (var i = 0; i < n; i++)
            {
                if (indegree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                var colorIndex = colors[node] - 'a';
                memo[node, colorIndex]++;

                maxColorValue = Math.Max(maxColorValue, memo[node, colorIndex]);

                foreach (var neighbor in adjList[node])
                {
                    for (var i = 0; i < 26; i++)
                    {
                        memo[neighbor, i] = Math.Max(memo[neighbor, i], memo[node, i]);
                    }

                    indegree[neighbor]--;

                    if (indegree[neighbor] == 0)
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }

            for (var i = 0; i < n; i++)
            {
                if (indegree[i] > 0)
                {
                    return -1;
                }
            }

            return maxColorValue;
        }
    }
}