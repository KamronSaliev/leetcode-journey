using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-operations-to-make-network-connected/
    /// </summary>
    public class Medium1319_NumberOfOperationsToMakeNetworkConnected
    {
        public int MakeConnected(int n, int[][] connections)
        {
            if (connections.Length < n - 1)
            {
                return -1;
            }
            
            var graph = new Dictionary<int, List<int>>();

            foreach (var connection in connections)
            {
                if (!graph.ContainsKey(connection[0]))
                {
                    graph.Add(connection[0], new List<int>());
                }

                if (!graph.ContainsKey(connection[1]))
                {
                    graph.Add(connection[1], new List<int>());
                }

                graph[connection[0]].Add(connection[1]);
                graph[connection[1]].Add(connection[0]);
            }

            var count = 0;
            var visited = new bool[n];

            for (var i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    count++;
                    BFS(i, graph, visited);
                }
            }

            return count - 1;
        }

        private void BFS(int i, Dictionary<int, List<int>> graph, bool[] visited)
        {
            var queue = new Queue<int>();
            queue.Enqueue(i);
            visited[i] = true;

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();

                if (!graph.ContainsKey(current))
                {
                    continue;
                }

                for (var j = 0; j < graph[current].Count; j++)
                {
                    if (!visited[graph[current][j]])
                    {
                        queue.Enqueue(graph[current][j]);
                        visited[graph[current][j]] = true;
                    }
                }
            }
        }
    }
}