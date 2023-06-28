using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/path-with-maximum-probability/
    /// </summary>
    public class Medium1514_PathWithMaximumProbability
    {
        public double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end)
        {
            var pathProb = GetAdjacencyMatrix(n, edges, succProb);
            var destProb = new PriorityQueue<int, double>();
            var visited = new bool[n];

            var dp = new double[n];
            Array.Fill(dp, -1);

            visited[start] = true;

            foreach (var path in pathProb[start])
            {
                destProb.Enqueue(path.Key, -pathProb[start][path.Key]);
                dp[path.Key] = pathProb[start][path.Key];
            }

            while (destProb.Count > 0)
            {
                var source = destProb.Dequeue();

                if (visited[source])
                {
                    continue;
                }

                visited[source] = true;

                foreach (var path in pathProb[source])
                {
                    if (!visited[path.Key])
                    {
                        var tempProb = dp[source] * pathProb[source][path.Key];
                        destProb.Enqueue(path.Key, -tempProb);
                        dp[path.Key] = Math.Max(dp[path.Key], tempProb);
                    }
                }
            }

            return dp[end] == -1 ? 0 : dp[end];
        }

        private Dictionary<int, Dictionary<int, double>> GetAdjacencyMatrix(int n, int[][] edges, double[] succProb)
        {
            Dictionary<int, Dictionary<int, double>> adj = new();

            for (var i = 0; i < n; i++)
            {
                adj.Add(i, new Dictionary<int, double>());
            }

            for (var i = 0; i < edges.Length; i++)
            {
                var node1 = edges[i][0];
                var node2 = edges[i][1];
                adj[node1].Add(node2, succProb[i]);
                adj[node2].Add(node1, succProb[i]);
            }

            return adj;
        }
    }
}