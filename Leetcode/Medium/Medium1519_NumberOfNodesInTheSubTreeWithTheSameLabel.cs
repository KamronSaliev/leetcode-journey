using System.Collections.Generic;
using Leetcode.Utilities;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-nodes-in-the-sub-tree-with-the-same-label/
    /// </summary>
    public class Medium1519_NumberOfNodesInTheSubTreeWithTheSameLabel
    {
        public int[] CountSubTrees(int n, int[][] edges, string labels)
        {
            var graph = GraphUtilities.BuildGraph(edges);

            var result = new int[n];
            DFS(0, -1, labels, result, graph);

            return result;
        }

        private int[] DFS(int node, int parent, string labels, int[] result, Dictionary<int, List<int>> graph)
        {
            var cnts = new int[26];
            cnts[labels[node] - 'a']++;

            foreach (var child in graph[node])
            {
                if (child == parent)
                {
                    continue;
                }

                var childCount = DFS(child, node, labels, result, graph);

                for (var i = 0; i < 26; i++)
                {
                    cnts[i] += childCount[i];
                }
            }

            result[node] = cnts[labels[node] - 'a'];

            return cnts;
        }
    }
}