using System;
using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-path-with-different-adjacent-characters/
    /// </summary>
    public class Hard2246_LongestPathWithDifferentAdjacentCharacters
    {
        public int LongestPath(int[] parent, string s)
        {
            var graph = BuildGraph(parent);
            var ans = 0;

            DFS(0, s, graph, ref ans);

            return ans;
        }

        private List<int>[] BuildGraph(int[] parent)
        {
            var graph = new List<int>[parent.Length];

            for (var i = 0; i < parent.Length; i++)
            {
                graph[i] = new List<int>();
            }

            for (var i = 0; i < parent.Length; i++)
            {
                if (parent[i] != -1)
                {
                    graph[parent[i]].Add(i);
                }
            }

            return graph;
        }

        private int DFS(int node, string s, List<int>[] graph, ref int ans)
        {
            var max1 = 0;
            var max2 = 0;

            foreach (var child in graph[node])
            {
                var length = DFS(child, s, graph, ref ans);

                if (s[child] == s[node])
                {
                    continue;
                }

                if (length > max1)
                {
                    max2 = max1;
                    max1 = length;
                }
                else if (length > max2)
                {
                    max2 = length;
                }
            }

            ans = Math.Max(ans, max1 + max2 + 1);
            return max1 + 1;
        }
    }
}