using System;
using System.Collections.Generic;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-closest-node-to-given-two-nodes/
    /// </summary>
    public class Medium2359_FindClosestNodeToGivenTwoNodes
    {
        public int ClosestMeetingNode(int[] edges, int node1, int node2)
        {
            var distNode1 = new int[edges.Length];
            var distNode2 = new int[edges.Length];

            Array.Fill(distNode1, int.MaxValue);
            Array.Fill(distNode2, int.MaxValue);

            BFS(node1, distNode1, edges);
            BFS(node2, distNode2, edges);

            var minDist = int.MaxValue;
            var node = -1;

            for (var i = 0; i < edges.Length; i++)
            {
                if (distNode1[i] == int.MaxValue || distNode2[i] == int.MaxValue)
                {
                    continue;
                }

                if (minDist > Math.Max(distNode1[i], distNode2[i]))
                {
                    node = i;
                    minDist = Math.Max(distNode1[i], distNode2[i]);
                }
            }

            return node;
        }

        private void BFS(int src, int[] dist, int[] edges)
        {
            var queue = new Queue<int>();
            queue.Enqueue(src);
            dist[src] = 0;

            while (queue.Count > 0)
            {
                var peek = queue.Dequeue();

                if (edges[peek] != -1 && dist[edges[peek]] == int.MaxValue)
                {
                    queue.Enqueue(edges[peek]);
                    dist[edges[peek]] = dist[peek] + 1;
                }
            }
        }
    }
}