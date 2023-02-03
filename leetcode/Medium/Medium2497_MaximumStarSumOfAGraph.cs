using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-star-sum-of-a-graph/
    /// </summary>
    public class Medium2497_MaximumStarSumOfAGraph
    {
        public int MaxStarSum(int[] vals, int[][] edges, int k)
        {
            var graph = new List<List<int>>((int)1e5);
            var n = vals.Length;

            for (var i = 0; i < 1e5; i++)
            {
                graph.Add(new List<int>());
            }

            for (var i = 0; i < edges.Length; i++)
            {
                var x = edges[i][0];
                var y = edges[i][1];
                graph[x].Add(vals[y]);
                graph[y].Add(vals[x]);
            }

            var ans = (int)-1e5;

            for (var i = 0; i < n; i++)
            {
                graph[i].Sort();
                graph[i].Reverse();

                var sum = 0;

                for (var j = 0; j < graph[i].Count && j < k; j++)
                {
                    if (graph[i][j] > 0)
                    {
                        sum += graph[i][j];
                    }
                    else
                    {
                        break;
                    }
                }

                ans = Math.Max(ans, sum + vals[i]);
            }

            return ans;
        }
    }
}