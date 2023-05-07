namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/island-perimeter/
    /// </summary>
    public class Easy463_IslandPerimeter
    {
        public int IslandPerimeter(int[][] grid)
        {
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        result += Count(grid, i, j);
                    }
                }
            }

            return result;
        }

        private int Count(int[][] grid, int x, int y)
        {
            var count = 0;

            if (x - 1 < 0 || grid[x - 1][y] == 0)
            {
                count++;
            }

            if (x + 1 > grid.Length - 1 || grid[x + 1][y] == 0)
            {
                count++;
            }

            if (y - 1 < 0 || grid[x][y - 1] == 0)
            {
                count++;
            }

            if (y + 1 > grid[x].Length - 1 || grid[x][y + 1] == 0)
            {
                count++;
            }

            return count;
        }
    }
}