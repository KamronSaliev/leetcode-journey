using System.Collections.Generic;

namespace LeetCode.Hard
{
    public class Hard2328_NumberOfIncreasingPathsInAGrid
    {
        private int[][] _visited;

        private const int Mod = (int)(1e9 + 7);

        public int CountPaths(int[][] grid)
        {
            _visited = new int[grid.Length][];

            for (var i = 0; i < grid.Length; i++)
            {
                _visited[i] = new int[grid[0].Length];
            }

            var sum = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    sum = (sum + Traverse((i, j), grid, 0)) % Mod;
                }
            }

            return sum;
        }

        private int Traverse((int, int) coordinates, int[][] grid, int last)
        {
            var x = coordinates.Item1;
            var y = coordinates.Item2;

            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length)
            {
                return 0;
            }

            if (grid[x][y] <= last)
            {
                return 0;
            }

            if (_visited[x][y] != 0)
            {
                return _visited[x][y];
            }

            var sum = 1;
            var directions = new List<(int, int)> { (x + 1, y), (x - 1, y), (x, y + 1), (x, y - 1) };

            foreach (var coordinate in directions)
            {
                sum = (sum + Traverse(coordinate, grid, grid[x][y])) % Mod;
            }

            _visited[x][y] = sum;
            return _visited[x][y];
        }
    }
}