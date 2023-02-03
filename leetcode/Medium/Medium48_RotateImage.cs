namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/rotate-image/
    /// </summary>
    public class Medium48_RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            Transpose(matrix);
            Reflect(matrix);
        }

        private void Transpose(int[][] matrix)
        {
            var n = matrix.Length;

            for (var i = 0; i < n; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }
            }
        }

        private void Reflect(int[][] matrix)
        {
            var n = matrix.Length;

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n / 2; j++)
                {
                    (matrix[i][j], matrix[i][n - j - 1]) = (matrix[i][n - j - 1], matrix[i][j]);
                }
            }
        }
    }
}