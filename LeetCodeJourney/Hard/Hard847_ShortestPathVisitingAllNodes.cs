using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/shortest-path-visiting-all-nodes/
    /// </summary>
    public class Hard847_ShortestPathVisitingAllNodes
    {
        public int ShortestPathLength(int[][] graph)
        {
            var n = graph.Length;
            var targetMask = (1 << n) - 1;
            var visited = new int[n][];

            for (var i = 0; i < n; i++)
            {
                visited[i] = new int[1 << n];
            }

            var queue = new Queue<(int, int, int)>();

            for (var i = 0; i < n; i++)
            {
                queue.Enqueue((i, 1 << i, 0));
                visited[i][1 << i] = 1;
            }

            while (queue.Count != 0)
            {
                var (node, mask, dist) = queue.Dequeue();

                if (mask == targetMask)
                {
                    return dist;
                }

                var size = graph[node].Length;

                for (var i = 0; i < size; i++)
                {
                    var neighbor = graph[node][i];
                    var newMask = mask | (1 << neighbor);

                    if (visited[neighbor][newMask] == 0)
                    {
                        visited[neighbor][newMask] = 1;
                        queue.Enqueue((neighbor, newMask, dist + 1));
                    }
                }
            }

            return -1;
        }
    }
}