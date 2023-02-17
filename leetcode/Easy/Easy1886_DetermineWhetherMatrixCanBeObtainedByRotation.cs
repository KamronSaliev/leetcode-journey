namespace LeetCode.Easy
{
    public class Easy1886_DetermineWhetherMatrixCanBeObtainedByRotation
    {
        public bool FindRotation(int[][] matrix, int[][] target)
        {
            for (var i = 0; i < 4; i++)
            {
                if (CheckRotation(matrix, target))
                {
                    return true;
                }

                Rotate(matrix);
            }

            return false;
        }

        private bool CheckRotation(int[][] matrix, int[][] target)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] != target[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void Rotate(int[][] matrix)
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