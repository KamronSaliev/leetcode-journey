using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-falling-path-sum/
    /// </summary>
    public class Medium931_MinimumFallingPathSum
    {
        public int MinFallingPathSum(int[][] matrix)
        {
            var rows = matrix.Length;
            var columns = matrix[0].Length;
            var result = int.MaxValue;

            for (var i = 1; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    var left = j > 0 ? matrix[i - 1][j - 1] : int.MaxValue;
                    var down = matrix[i - 1][j];
                    var right = j < columns - 1 ? matrix[i - 1][j + 1] : int.MaxValue;

                    matrix[i][j] += Math.Min(Math.Min(left, down), right);
                }
            }

            for (var j = 0; j < columns; j++)
            {
                result = Math.Min(result, matrix[rows - 1][j]);
            }

            return result;
        }
    }
}