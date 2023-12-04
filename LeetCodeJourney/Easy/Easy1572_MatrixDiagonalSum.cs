using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/matrix-diagonal-sum/
    /// </summary>
    public class Easy1572_MatrixDiagonalSum
    {
        public int DiagonalSum(int[][] mat)
        {
            var size = mat.Length;
            var sum = 0;

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    if (i == j || i + j == size - 1)
                    {
                        sum += mat[i][j];
                    }
                }
            }

            return sum;
        }
    }
}