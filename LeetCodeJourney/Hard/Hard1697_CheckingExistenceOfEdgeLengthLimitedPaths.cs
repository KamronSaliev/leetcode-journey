using System;
using LeetCode.Utilities;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/checking-existence-of-edge-length-limited-paths/
    /// </summary>
    public class Hard1697_CheckingExistenceOfEdgeLengthLimitedPaths
    {
        public bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries)
        {
            var dsu = new DisjointSetUnion(n);

            for (var i = 0; i < queries.Length; i++)
            {
                queries[i] = new[] { queries[i][0], queries[i][1], queries[i][2], i };
            }

            Array.Sort(queries, (a, b) => a[2] - b[2]);
            Array.Sort(edgeList, (a, b) => a[2] - b[2]);

            var result = new bool[queries.Length];
            var j = 0;

            foreach (var query in queries)
            {
                for (; j < edgeList.Length && edgeList[j][2] < query[2]; ++j)
                {
                    dsu.Union(edgeList[j][0], edgeList[j][1]);
                }

                result[query[3]] = dsu.Find(query[0]) == dsu.Find(query[1]);
            }

            return result;
        }
    }
}