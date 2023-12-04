namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-enclaves/
    /// </summary>
    public class Medium1020_NumberOfEnclaves
    {
        public int NumEnclaves(int[][] grid)
        {
            var countOnes = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        countOnes++;
                    }
                }
            }

            var result = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    var count = 0;
                    if (grid[i][j] == 1 && DFS(grid, i, j, ref count))
                    {
                        result += count;
                    }
                }
            }

            return countOnes - result;
        }

        private bool DFS(int[][] grid, int sr, int sc, ref int count)
        {
            if (sr < 0 || sr >= grid.Length || sc < 0 || sc >= grid[0].Length)
            {
                return true;
            }

            if (grid[sr][sc] != 1)
            {
                return false;
            }

            count++;
            grid[sr][sc] = 0;
            var result = false;

            result |= DFS(grid, sr - 1, sc, ref count);
            result |= DFS(grid, sr + 1, sc, ref count);
            result |= DFS(grid, sr, sc - 1, ref count);
            result |= DFS(grid, sr, sc + 1, ref count);

            return result;
        }
    }
}