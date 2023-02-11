using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/shortest-path-with-alternating-colors/
    /// </summary>
    public class Medium1129_ShortestPathWithAlternatingColors
    {
        public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges)
        {
            var red = new List<int>[n];
            var blue = new List<int>[n];
            for (var i = 0; i < n; i++)
            {
                red[i] = new List<int>();
                blue[i] = new List<int>();
            }

            foreach (var redEdge in redEdges)
            {
                red[redEdge[0]].Add(redEdge[1]);
            }

            foreach (var blueEdge in blueEdges)
            {
                blue[blueEdge[0]].Add(blueEdge[1]);
            }

            var result = new int[n];
            for (var i = 0; i < n; i++)
            {
                result[i] = -1;
            }

            var queue = new Queue<(int node, bool isRedColor)>();
            queue.Enqueue((0, true));
            queue.Enqueue((0, false));

            var visited = new HashSet<(int node, bool isRedColor)>
            {
                (0, true),
                (0, false)
            };

            var level = 0;

            while (queue.Count != 0)
            {
                var size = queue.Count;

                for (var i = 0; i < size; i++)
                {
                    var (node, isRedColor) = queue.Dequeue();
                    if (result[node] == -1)
                    {
                        result[node] = level;
                    }

                    if (isRedColor)
                    {
                        foreach (var _ in red[node].Where(_ => !visited.Contains((_, false))))
                        {
                            queue.Enqueue((_, false));
                            visited.Add((_, false));
                        }
                    }
                    else
                    {
                        foreach (var _ in blue[node].Where(_ => !visited.Contains((_, true))))
                        {
                            queue.Enqueue((_, true));
                            visited.Add((_, true));
                        }
                    }
                }

                level++;
            }

            return result;
        }
    }
}