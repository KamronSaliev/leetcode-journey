using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/01-matrix/
    /// </summary>
    public class Medium542_01Matrix
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            var queue = new Queue<Coordinate>();

            for (var i = 0; i < mat.Length; i++)
            {
                for (var j = 0; j < mat[0].Length; j++)
                {
                    if (mat[i][j] != 0)
                    {
                        mat[i][j] = int.MaxValue;
                    }
                    else
                    {
                        queue.Enqueue(new Coordinate(i, j));
                    }
                }
            }

            var directions = new[] { -1, 0, 1, 0, -1 };

            while (queue.Count != 0)
            {
                var currentCoordinate = queue.Dequeue();

                for (var i = 0; i < 4; i++)
                {
                    UpdateAdjacentCoordinate(mat, queue, currentCoordinate,
                        currentCoordinate.X + directions[i], currentCoordinate.Y + directions[i + 1]);
                }
            }

            return mat;
        }

        private void UpdateAdjacentCoordinate(int[][] mat, Queue<Coordinate> queue, Coordinate initialCoordinate, int i,
            int j)
        {
            if (i < 0 || i >= mat.Length || j < 0 || j >= mat[0].Length || mat[i][j] != int.MaxValue)
            {
                return;
            }

            mat[i][j] = mat[initialCoordinate.X][initialCoordinate.Y] + 1;
            queue.Enqueue(new Coordinate(i, j));
        }
    }
}