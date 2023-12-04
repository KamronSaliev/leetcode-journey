using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-time-to-collect-all-apples-in-a-tree/
    /// </summary>
    public class Medium1443_MinimumTimeToCollectAllApplesInATree
    {
        public int MinTime(int n, int[][] edges, IList<bool> hasApple)
        {
            var graph = GraphUtilities.BuildGraph(edges);

            return DFS(0, -1, hasApple, graph);
        }

        private int DFS(int node, int parent, IList<bool> hasApple, Dictionary<int, List<int>> graph)
        {
            if (!graph.ContainsKey(node))
            {
                return 0;
            }

            var totalTime = 0;

            foreach (var child in graph[node])
            {
                if (child == parent)
                {
                    continue;
                }
                
                var childTime = DFS(child, node, hasApple, graph);

                if (childTime > 0 || hasApple[child])
                {
                    totalTime += childTime + 2;
                }
            }

            return totalTime;
        }
    }
}