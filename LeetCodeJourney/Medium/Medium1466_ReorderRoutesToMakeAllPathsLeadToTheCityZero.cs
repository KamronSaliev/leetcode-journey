using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/reorder-routes-to-make-all-paths-lead-to-the-city-zero/
    /// </summary>
    public class Medium1466_ReorderRoutesToMakeAllPathsLeadToTheCityZero
    {
        public int MinReorder(int n, int[][] connections)
        {
            var graph = BuildGraph(connections);
            var result = 0;
            var queue = new Queue<int>();
            var visited = new HashSet<int>();

            queue.Enqueue(0);
            visited.Add(0);

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();

                foreach (var node in graph[current])
                {
                    if (!visited.Contains(node.index))
                    {
                        queue.Enqueue(node.index);
                        visited.Add(node.index);

                        if (node.isDirect)
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }

        private Dictionary<int, List<(int index, bool isDirect)>> BuildGraph(int[][] connections)
        {
            var graph = new Dictionary<int, List<(int index, bool isDirect)>>();
            foreach (var connection in connections)
            {
                if (!graph.ContainsKey(connection[0]))
                {
                    graph.Add(connection[0], new List<(int index, bool isDirect)> { (connection[1], true) });
                }
                else
                {
                    graph[connection[0]].Add((connection[1], true));
                }

                if (!graph.ContainsKey(connection[1]))
                {
                    graph.Add(connection[1], new List<(int index, bool isDirect)> { (connection[0], false) });
                }
                else
                {
                    graph[connection[1]].Add((connection[0], false));
                }
            }

            return graph;
        }
    }
}