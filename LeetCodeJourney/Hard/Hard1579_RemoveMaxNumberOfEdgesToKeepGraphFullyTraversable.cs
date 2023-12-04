using System;
using LeetCode.Utilities;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/remove-max-number-of-edges-to-keep-graph-fully-traversable/
    /// </summary>
    public class Hard1579_RemoveMaxNumberOfEdgesToKeepGraphFullyTraversable
    {
        public int MaxNumEdgesToRemove(int n, int[][] edges)
        {
            var numRemovedEdges = 0;

            Array.Sort(edges, (a, b) => b[0] - a[0]);

            var ufAlice = new DisjointSetUnion(n + 1);
            var ufBob = new DisjointSetUnion(n + 1);

            foreach (var edge in edges)
            {
                if (edge[0] == 3)
                {
                    if (ufAlice.Union(edge[1], edge[2]))
                    {
                        ufBob.Union(edge[1], edge[2]);
                    }
                    else
                    {
                        numRemovedEdges++;
                    }
                }
            }

            foreach (var edge in edges)
            {
                if (edge[0] == 1)
                {
                    if (!ufAlice.Union(edge[1], edge[2]))
                    {
                        numRemovedEdges++;
                    }
                }
            }

            foreach (var edge in edges)
            {
                if (edge[0] == 2)
                {
                    if (!ufBob.Union(edge[1], edge[2]))
                    {
                        numRemovedEdges++;
                    }
                }
            }

            var aliceFullyTraversable = true;
            var bobFullyTraversable = true;
            
            for (var i = 2; i <= n; i++)
            {
                if (ufAlice.Find(i) != ufAlice.Find(1))
                {
                    aliceFullyTraversable = false;
                }

                if (ufBob.Find(i) != ufBob.Find(1))
                {
                    bobFullyTraversable = false;
                }
            }

            if (!aliceFullyTraversable || !bobFullyTraversable)
            {
                return -1;
            }

            return numRemovedEdges;
        }
    }
}