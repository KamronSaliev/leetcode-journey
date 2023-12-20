namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/difference-between-ones-and-zeros-in-row-and-column/
    /// </summary>
    public class Medium2482_DifferenceBetweenOnesAndZerosInRowAndColumn
    {
        public int[][] OnesMinusZeros(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var onesRow = new int[m];
            var onesCol = new int[n];
            var result = new int[m][];

            for (var i = 0; i < m; i++)
            {
                result[i] = new int[n];
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    onesRow[i] += grid[i][j];
                    onesCol[j] += grid[i][j];
                }
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    result[i][j] = 2 * onesRow[i] + 2 * onesCol[j] - n - m;
                }
            }

            return result;
        }
    }
}