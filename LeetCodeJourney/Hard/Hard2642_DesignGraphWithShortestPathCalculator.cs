using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/design-graph-with-shortest-path-calculator/
    /// </summary>
    public class Hard2642_DesignGraphWithShortestPathCalculator
    {
        public class Graph
        {
            private readonly int _size;
            private readonly Dictionary<int, List<int[]>> _graph;

            public Graph(int n, int[][] edges)
            {
                _size = n;
                _graph = new Dictionary<int, List<int[]>>();

                foreach (var edge in edges)
                {
                    AddEdge(edge);
                }
            }

            public void AddEdge(int[] edge)
            {
                var from = edge[0];
                var to = edge[1];
                var cost = edge[2];

                if (!_graph.ContainsKey(from))
                {
                    _graph[from] = new List<int[]>();
                }

                _graph[from].Add(new[] { to, cost });
            }

            public int ShortestPath(int node1, int node2)
            {
                var distance = new int[_size];
                var visited = new bool[_size];

                for (var i = 0; i < _size; i++)
                {
                    distance[i] = int.MaxValue;
                }

                distance[node1] = 0;

                for (var i = 0; i < _size - 1; i++)
                {
                    var u = MinDistance(distance, visited);
                    visited[u] = true;

                    if (!_graph.TryGetValue(u, out var value))
                    {
                        continue;
                    }

                    foreach (var neighbor in value)
                    {
                        var v = neighbor[0];
                        var cost = neighbor[1];

                        if (!visited[v] && distance[u] != int.MaxValue && distance[u] + cost < distance[v])
                        {
                            distance[v] = distance[u] + cost;
                        }
                    }
                }

                return distance[node2] == int.MaxValue ? -1 : distance[node2];
            }

            private int MinDistance(int[] distance, bool[] visited)
            {
                var min = int.MaxValue;
                var minIndex = -1;

                for (var v = 0; v < _size; v++)
                {
                    if (visited[v] || distance[v] > min)
                    {
                        continue;
                    }

                    min = distance[v];
                    minIndex = v;
                }

                return minIndex;
            }
        }
    }
}