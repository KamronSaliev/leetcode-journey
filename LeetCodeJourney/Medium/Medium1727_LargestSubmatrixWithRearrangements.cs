using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/largest-submatrix-with-rearrangements/
    /// </summary>
    public class Medium1727_LargestSubmatrixWithRearrangements
    {
        public int LargestSubmatrix(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            var result = 0;

            for (var i = 1; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        matrix[i][j] += matrix[i - 1][j];
                    }
                }
            }

            for (var i = 0; i < m; i++)
            {
                Array.Sort(matrix[i]);

                for (var j = n - 1; j >= 0; j--)
                {
                    result = Math.Max(result, matrix[i][j] * (n - j));
                }
            }

            return result;
        }
    }
}