namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/transpose-matrix/
    /// </summary>
    public class Easy867_TransposeMatrix
    {
        public int[][] Transpose(int[][] matrix)
        {
            var result = new int[matrix[0].Length][];

            for (var i = 0; i < matrix[0].Length; i++)
            {
                result[i] = new int[matrix.Length];
                for (var j = 0; j < matrix.Length; j++)
                {
                    result[i][j] = matrix[j][i];
                }
            }

            return result;
        }
    }
}