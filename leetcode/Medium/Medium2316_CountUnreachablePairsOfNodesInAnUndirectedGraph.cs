using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/count-unreachable-pairs-of-nodes-in-an-undirected-graph/
    /// </summary>
    public class Medium2316_CountUnreachablePairsOfNodesInAnUndirectedGraph
    {
        public long CountPairs(int n, int[][] edges)
        {
            var result = 0L;
            var count = 0L;
            var totalCount = (long)n;
            var visited = new bool[n];

            var graph = Enumerable.Range(0, n).ToDictionary(x => x, x => new List<int>());
            
            for (var i = 0; i < edges.Length; i++)
            {
                graph[edges[i][0]].Add(edges[i][1]);
                graph[edges[i][1]].Add(edges[i][0]);
            }

            for (var i = 0; i < n; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                var queue = new Queue<int>();
                queue.Enqueue(i);
                
                while (queue.Count != 0)
                {
                    var item = queue.Dequeue();
                    if (!visited[item])
                    {
                        visited[item] = true;
                        count++;
                        
                        for (var k = 0; k < graph[item].Count; k++)
                        {
                            queue.Enqueue(graph[item][k]);
                        }
                    }
                }

                if (count > 0)
                {
                    result += (totalCount - count) * count;
                    totalCount -= count;
                    count = 0;
                }
            }

            return result;
        }
    }
}