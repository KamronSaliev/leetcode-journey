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
            for (var i = 0; i < matrix.Length; i++)
            {
                var rowHashSet = new HashSet<int>();

                for (var j = 0; j < matrix[0].Length; j++)
                {
                    rowHashSet.Add(matrix[i][j]);
                }

                if (rowHashSet.Count != matrix.Length)
                {
                    return false;
                }
            }

            for (var i = 0; i < matrix.Length; i++)
            {
                var columnHashSet = new HashSet<int>();

                for (var j = 0; j < matrix[0].Length; j++)
                {
                    columnHashSet.Add(matrix[j][i]);
                }

                if (columnHashSet.Count != matrix.Length)
                {
                    return false;
                }
            }

            return true;
        }
    }
}