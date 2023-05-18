using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-number-of-vertices-to-reach-all-nodes/
    /// </summary>
    public class Medium1557_MinimumNumberOfVerticesToReachAllNodes
    {
        public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
        {
            var inNodes = new bool[n];
            var result = new List<int>();

            for (var i = 0; i < edges.Count; i++)
            {
                inNodes[edges[i][1]] = true;
            }

            for (var i = 0; i < n; i++)
            {
                if (!inNodes[i])
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}