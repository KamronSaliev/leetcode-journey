namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/special-positions-in-a-binary-matrix/
    /// </summary>
    public class Easy1582_SpecialPositionsInABinaryMatrix
    {
        public int NumSpecial(int[][] mat)
        {
            var result = 0;

            for (var i = 0; i < mat.Length; i++)
            {
                for (var j = 0; j < mat[0].Length; j++)
                {
                    if (mat[i][j] == 1 && IsSpecial(i, j, mat))
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        private bool IsSpecial(int i, int j, int[][] mat)
        {
            for (var k = 0; k < mat.Length; k++)
            {
                if (k != i && mat[k][j] == 1)
                {
                    return false;
                }
            }
            
            for (var k = 0; k < mat[0].Length; k++)
            {
                if (k != j && mat[i][k] == 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}