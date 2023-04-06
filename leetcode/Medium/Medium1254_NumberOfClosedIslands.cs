namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-closed-islands/
    /// </summary>
    public class Medium1254_NumberOfClosedIslands
    {
        public int ClosedIsland(int[][] grid)
        {
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        if (DFS(grid, i, j))
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }


        private bool DFS(int[][] grid, int sr, int sc)
        {
            if (sr < 0 || sr >= grid.Length || sc < 0 || sc >= grid[0].Length)
            {
                return false;
            }

            if (grid[sr][sc] == 1)
            {
                return true;
            }

            grid[sr][sc] = 1;
            var result = true;

            result &= DFS(grid, sr - 1, sc);
            result &= DFS(grid, sr + 1, sc);
            result &= DFS(grid, sr, sc - 1);
            result &= DFS(grid, sr, sc + 1);

            return result;
        }
    }
}