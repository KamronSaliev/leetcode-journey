namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/toeplitz-matrix/
    /// </summary>
    public class Easy766_ToeplitzMatrix
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;

            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < m; j++)
                {
                    if (matrix[i][j] != matrix[i - 1][j - 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}