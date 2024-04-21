using System.Collections.Generic;
using System.Linq;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-if-path-exists-in-graph
    /// </summary>
    public class Medium1971_FindIfPathExistsInGraph
    {
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            var graph = GraphUtilities.BuildGraph(edges);

            return BFS(graph, source, destination);
        }

        private bool BFS(Dictionary<int, List<int>> adj, int source, int destination)
        {
            var visited = new HashSet<int>();
            var queue = new Queue<int>();
            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                visited.Add(current);

                if (current == destination)
                {
                    return true;
                }

                foreach (var v in adj[current].Where(v => !visited.Contains(v)))
                {
                    queue.Enqueue(v);
                    visited.Add(v);
                }
            }

            return false;
        }
    }
}