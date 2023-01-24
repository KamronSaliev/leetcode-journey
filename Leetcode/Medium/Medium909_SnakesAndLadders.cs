using System;
using System.Collections.Generic;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/snakes-and-ladders/
    /// </summary>
    public class Medium909_SnakesAndLadders
    {
        public int SnakesAndLadders(int[][] board)
        {
            var n = board.Length;
            var cells = new KeyValuePair<int, int>[n * n + 1];
            var label = 1;
            var columns = new int[n];

            for (var i = 0; i < n; i++)
            {
                columns[i] = i;
            }

            for (var row = n - 1; row >= 0; row--)
            {
                foreach (var column in columns)
                {
                    cells[label++] = new KeyValuePair<int, int>(row, column);
                }

                Array.Reverse(columns);
            }

            var dist = new int[n * n + 1];
            Array.Fill(dist, -1);

            var q = new Queue<int>();
            dist[1] = 0;
            q.Enqueue(1);

            while (q.Count > 0)
            {
                var curr = q.Dequeue();

                for (var i = curr + 1; i <= Math.Min(curr + 6, n * n); i++)
                {
                    int row = cells[i].Key, column = cells[i].Value;
                    var destination = board[row][column] != -1 ? board[row][column] : i;

                    if (dist[destination] == -1)
                    {
                        dist[destination] = dist[curr] + 1;
                        q.Enqueue(destination);
                    }
                }
            }

            return dist[n * n];
        }
    }
}