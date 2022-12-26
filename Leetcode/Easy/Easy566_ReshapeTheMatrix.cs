using System.Collections.Generic;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/reshape-the-matrix/
    /// </summary>
    public class Easy566_ReshapeTheMatrix
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            var list = new List<int>();
            var reshapedMatrix = new int[r][];
            var index = 0;
            var rows = 0;

            for (var i = 0; i < mat.Length; i++)
            {
                for (var j = 0; j < mat[0].Length; j++)
                {
                    list.Add(mat[i][j]);
                }
            }

            while (rows < r)
            {
                reshapedMatrix[rows] = new int[c];

                for (var i = 0; i < c; i++)
                {
                    reshapedMatrix[rows][i] = list[index++];
                }

                rows++;
            }

            return reshapedMatrix;
        }
    }
}