using System.Collections.Generic;

namespace LeetCode.Utilities
{
    public static class GraphUtilities
    {
        public static Dictionary<int, List<int>> BuildGraph(int[][] edges)
        {
            var graph = new Dictionary<int, List<int>>();
            
            foreach (var edge in edges)
            {
                var a = edge[0];
                var b = edge[1];

                if (!graph.ContainsKey(a))
                {
                    graph.Add(a, new List<int>());
                }

                if (!graph.ContainsKey(b))
                {
                    graph.Add(b, new List<int>());
                }

                graph[a].Add(b);
                graph[b].Add(a);
            }

            return graph;
        }
    }
}