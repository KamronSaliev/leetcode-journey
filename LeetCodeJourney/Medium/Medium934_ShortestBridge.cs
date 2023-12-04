using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/shortest-bridge/
    /// </summary>
    public class Medium934_ShortestBridge
    {
        public int ShortestBridge(int[][] grid)
        {
            var island = 10001;
            var shortestBridge = int.MaxValue;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        DFS(grid, i, j, island);
                        island++;
                    }
                }
            }

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 10001)
                    {
                        shortestBridge = Math.Min(shortestBridge, BFS(grid, i, j));
                    }
                }
            }

            return shortestBridge;
        }

        private void DFS(int[][] grid, int row, int col, int val)
        {
            if (row < 0 || row >= grid.Length || col < 0 || col >= grid[row].Length || grid[row][col] == val ||
                grid[row][col] == 0)
            {
                return;
            }

            grid[row][col] = val;
            DFS(grid, row - 1, col, val);
            DFS(grid, row + 1, col, val);
            DFS(grid, row, col - 1, val);
            DFS(grid, row, col + 1, val);
        }

        private int BFS(int[][] grid, int row, int col)
        {
            Queue<int[]> queue = new();
            var n = grid.Length;
            var visited = new bool[n, n];
            queue.Enqueue(new int[2] { row - 1, col });
            queue.Enqueue(new int[2] { row + 1, col });
            queue.Enqueue(new int[2] { row, col - 1 });
            queue.Enqueue(new int[2] { row, col + 1 });
            var distance = 0;

            while (queue.Count > 0)
            {
                var count = queue.Count;

                while (count-- > 0)
                {
                    var cur = queue.Dequeue();
                    row = cur[0];
                    col = cur[1];

                    if (row < 0 || row >= grid.Length || col < 0 || col >= grid.Length || grid[row][col] == 10001 ||
                        visited[row, col])
                    {
                        continue;
                    }

                    visited[row, col] = true;

                    if (grid[row][col] == 10002)
                    {
                        return distance;
                    }

                    queue.Enqueue(new[] { row - 1, col });
                    queue.Enqueue(new[] { row + 1, col });
                    queue.Enqueue(new[] { row, col - 1 });
                    queue.Enqueue(new[] { row, col + 1 });
                }

                distance++;
            }

            return int.MaxValue;
        }
    }
}