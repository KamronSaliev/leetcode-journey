using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/
    /// </summary>
    public class Easy1337_TheKWeakestRowsInAMatrix
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < mat.Length; i++)
            {
                var sum = 0;

                for (var j = 0; j < mat[0].Length; j++)
                {
                    sum += mat[i][j];
                }

                dictionary.Add(i, sum);
            }

            return dictionary.OrderBy(d => d.Value).Select(d => d.Key).Take(k).ToArray();
        }
    }
}