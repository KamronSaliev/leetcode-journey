using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/path-with-minimum-effort/
    /// </summary>
    public class Medium1631_PathWithMinimumEffort
    {
        public int MinimumEffortPath(int[][] heights)
        {
            var rows = heights.Length;
            var cols = heights[0].Length;
            var distances = new int[rows, cols];
            int[][] directions = { new[] { 0, 1 }, new[] { 0, -1 }, new[] { 1, 0 }, new[] { -1, 0 } };
            var minHeap = new SortedSet<(int effort, int x, int y)> { (0, 0, 0) };

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    distances[i, j] = int.MaxValue;
                }
            }

            distances[0, 0] = 0;

            while (minHeap.Count > 0)
            {
                var (effort, x, y) = minHeap.Min;
                minHeap.Remove(minHeap.Min);

                if (effort > distances[x, y])
                {
                    continue;
                }

                if (x == rows - 1 && y == cols - 1)
                {
                    return effort;
                }

                foreach (var direction in directions)
                {
                    var currentX = x + direction[0];
                    var currentY = y + direction[1];

                    if (currentX >= 0 && currentX < rows && currentY >= 0 && currentY < cols)
                    {
                        var currentEffort = Math.Max(effort, Math.Abs(heights[x][y] - heights[currentX][currentY]));

                        if (currentEffort < distances[currentX, currentY])
                        {
                            distances[currentX, currentY] = currentEffort;
                            minHeap.Add((currentEffort, currentX, currentY));
                        }
                    }
                }
            }

            return -1;
        }
    }
}