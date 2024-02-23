using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/cheapest-flights-within-k-stops/
    /// </summary>
    public class Medium787_CheapestFlightsWithinKStops
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            var graph = new Dictionary<int, List<(int, int)>>();
            var dist = new int[n];

            for (var i = 0; i < n; i++)
            {
                dist[i] = int.MaxValue;
                graph.Add(i, new List<(int, int)>());
            }

            foreach (var flight in flights)
            {
                graph[flight[0]].Add((flight[1], flight[2]));
            }

            BFS(src, dist, graph, k);

            return dist[dst] == int.MaxValue ? -1 : dist[dst];
        }

        private void BFS(int src, int[] dist, Dictionary<int, List<(int, int)>> graph, int k)
        {
            var queue = new Queue<(int, int)>();
            queue.Enqueue((0, src));
            dist[src] = 0;
            var count = 0;

            while (queue.Count > 0 && count <= k)
            {
                var size = queue.Count;

                while (size-- > 0)
                {
                    var state = queue.Dequeue();

                    var price = state.Item1;
                    var node = state.Item2;

                    foreach (var item in graph[node])
                    {
                        var node2 = item.Item1;

                        if (dist[node2] > item.Item2 + price)
                        {
                            dist[node2] = item.Item2 + price;
                            queue.Enqueue((dist[node2], node2));
                        }
                    }
                }

                count++;
            }
        }
    }
}