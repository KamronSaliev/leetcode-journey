namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-islands/
    /// </summary>
    public class Medium200_NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            var counter = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        counter++;
                        
                        DFS(grid, i, j);
                    }
                }
            }

            return counter;
        }
        
        private void DFS(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0')
            {
                return;
            }

            grid[i][j] = '0';
            DFS(grid, i - 1, j);
            DFS(grid, i + 1, j);
            DFS(grid, i, j - 1);
            DFS(grid, i, j + 1);
        }
    }
}