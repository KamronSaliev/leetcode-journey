using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/check-if-every-row-and-column-contains-all-numbers/
    /// </summary>
    public class Easy2133_CheckIfEveryRowAndColumnContainsAllNumbers
    {
        public bool CheckValid(int[][] matrix)
        {
            return CheckRowWise(matrix) && CheckColumnWise(matrix);
        }

        private bool CheckRowWise(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                var hashSet = new HashSet<int>();

                for (var j = 0; j < matrix[0].Length; j++)
                {
                    hashSet.Add(matrix[i][j]);
                }

                if (hashSet.Count != matrix.Length)
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckColumnWise(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                var hashSet = new HashSet<int>();

                for (var j = 0; j < matrix[0].Length; j++)
                {
                    hashSet.Add(matrix[j][i]);
                }

                if (hashSet.Count != matrix.Length)
                {
                    return false;
                }
            }

            return true;
        }
    }
}