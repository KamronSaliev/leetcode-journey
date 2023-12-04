using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/as-far-from-land-as-possible/
    /// </summary>
    public class Medium1162_AsFarFromLandAsPossible
    {
        public int MaxDistance(int[][] grid)
        {
            var queue = new Queue<(int X, int Y)>();
            var visited = new bool[grid.Length, grid.Length];
            var directions = new (int X, int Y)[] { (0, 1), (0, -1), (-1, 0), (1, 0) };
            var distance = -1;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    visited[i, j] = grid[i][j] == 1;

                    if (grid[i][j] == 1)
                    {
                        queue.Enqueue((i, j));
                    }
                }
            }

            while (queue.Count != 0)
            {
                var size = queue.Count;

                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();

                    foreach (var direction in directions)
                    {
                        var newCoordinateX = current.X + direction.X;
                        var newCoordinateY = current.Y + direction.Y;

                        if (newCoordinateX < 0 || newCoordinateX >= grid.Length ||
                            newCoordinateY < 0 || newCoordinateY >= grid[0].Length ||
                            visited[newCoordinateX, newCoordinateY])
                        {
                            continue;
                        }

                        queue.Enqueue((newCoordinateX, newCoordinateY));
                        visited[newCoordinateX, newCoordinateY] = true;
                    }
                }

                distance++;
            }

            return distance != 0 ? distance : -1;
        }
    }
}