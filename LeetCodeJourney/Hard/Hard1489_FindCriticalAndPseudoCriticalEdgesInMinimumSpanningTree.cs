using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/find-critical-and-pseudo-critical-edges-in-minimum-spanning-tree/
    /// </summary>
    public class Hard1489_FindCriticalAndPseudoCriticalEdgesInMinimumSpanningTree
    {
        public IList<IList<int>> FindCriticalAndPseudoCriticalEdges(int n, int[][] edges)
        {
            var mstCost = Kruskal(GetEdges(edges), n);
            var result = new List<IList<int>> { new List<int>(), new List<int>() };

            for (var i = 0; i < edges.Length; i++)
            {
                var currentCost = Kruskal(GetEdges(edges, i), n);
                if (currentCost > mstCost)
                {
                    result[0].Add(i);
                }
                else
                {
                    var taken = new Edge { Id = i, From = edges[i][0], To = edges[i][1], Cost = edges[i][2] };
                    currentCost = Kruskal(GetEdges(edges), n, taken);

                    if (currentCost == mstCost)
                    {
                        result[1].Add(i);
                    }
                }
            }

            return result;
        }

        private int Kruskal(PriorityQueue<Edge, int> edges, int nodes, Edge taken = null)
        {
            var result = 0;
            var dsu = new DisjointSetUnion(nodes);

            if (taken != null)
            {
                dsu.Union(taken.From, taken.To);
                result += taken.Cost;
            }

            while (dsu.Count > 1 && edges.Count > 0)
            {
                var edge = edges.Dequeue();

                if (dsu.IsSameComponent(edge.From, edge.To))
                {
                    continue;
                }

                dsu.Union(edge.From, edge.To);
                result += edge.Cost;
            }

            if (dsu.Count > 1)
            {
                return int.MaxValue;
            }

            return result;
        }

        private PriorityQueue<Edge, int> GetEdges(int[][] edges, int skippedIndex = -1)
        {
            PriorityQueue<Edge, int> edgesPriorityQueue = new(Comparer<int>.Create((a, b) => a.CompareTo(b)));
            for (var i = 0; i < edges.Length; i++)
            {
                if (i == skippedIndex)
                {
                    continue;
                }

                edgesPriorityQueue.Enqueue(
                    new Edge { Id = i, From = edges[i][0], To = edges[i][1], Cost = edges[i][2] },
                    edges[i][2]);
            }

            return edgesPriorityQueue;
        }

        private class Edge
        {
            public int Id { get; set; }
            public int From { get; set; }
            public int To { get; set; }
            public int Cost { get; set; }
        }
    }
}