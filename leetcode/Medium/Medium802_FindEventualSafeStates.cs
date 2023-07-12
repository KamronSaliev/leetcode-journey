using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-eventual-safe-states/
    /// </summary>
    public class Medium802_FindEventualSafeStates
    {
        public IList<int> EventualSafeNodes(int[][] graph)
        {
            var safeNodes = new HashSet<int>();
            var visited = new HashSet<int>();

            return Enumerable.Range(0, graph.Length)
                .Where(IsSafe)
                .ToArray();

            bool IsSafe(int node)
            {
                if (visited.Contains(node))
                {
                    return safeNodes.Contains(node);
                }

                visited.Add(node);

                if (graph[node].All(IsSafe))
                {
                    safeNodes.Add(node);
                }

                return safeNodes.Contains(node);
            }
        }
    }
}