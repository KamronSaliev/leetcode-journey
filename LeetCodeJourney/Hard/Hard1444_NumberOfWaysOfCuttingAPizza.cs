namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-ways-of-cutting-a-pizza/
    /// </summary>
    public class Hard1444_NumberOfWaysOfCuttingAPizza
    {
        public int Ways(string[] pizza, int k)
        {
            var rows = pizza.Length;
            var cols = pizza[0].Length;

            var apples = new int[rows + 1, cols + 1];
            var f = new int[rows, cols];

            for (var row = rows - 1; row >= 0; row--)
            {
                for (var col = cols - 1; col >= 0; col--)
                {
                    var num = (pizza[row][col] == 'A' ? 1 : 0) + apples[row + 1, col] + apples[row, col + 1] -
                              apples[row + 1, col + 1];
                    apples[row, col] = num;
                    f[row, col] = num > 0 ? 1 : 0;
                }
            }

            const int mod = 1000000007;

            for (var remain = 1; remain < k; remain++)
            {
                var g = new int[rows, cols];

                for (var row = 0; row < rows; row++)
                {
                    for (var col = 0; col < cols; col++)
                    {
                        for (var nextRow = row + 1; nextRow < rows; nextRow++)
                        {
                            if (apples[row, col] - apples[nextRow, col] > 0)
                            {
                                g[row, col] = (g[row, col] + f[nextRow, col]) % mod;
                            }
                        }

                        for (var nextCol = col + 1; nextCol < cols; nextCol++)
                        {
                            if (apples[row, col] - apples[row, nextCol] > 0)
                            {
                                g[row, col] = (g[row, col] + f[row, nextCol]) % mod;
                            }
                        }
                    }
                }

                f = g;
            }

            return f[0, 0];
        }
    }
}