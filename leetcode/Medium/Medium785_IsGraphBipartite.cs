using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/is-graph-bipartite/
    /// </summary>
    public class Medium785_IsGraphBipartite
    {
        public bool IsBipartite(int[][] graph)
        {
            var colors = new int[graph.Length];

            for (var i = 0; i < graph.Length; i++)
            {
                if (colors[i] != 0)
                {
                    continue;
                }

                colors[i] = 1;
                var queue = new Queue<int>();
                
                queue.Enqueue(i);

                while (queue.Count != 0)
                {
                    var current = queue.Dequeue();

                    foreach (var child in graph[current])
                    {
                        if (colors[child] == colors[current])
                        {
                            return false;
                        }

                        if (colors[child] == 0)
                        {
                            colors[child] = -colors[current];
                            queue.Enqueue(child);
                        }
                    }
                }
            }

            return true;
        }
    }
}