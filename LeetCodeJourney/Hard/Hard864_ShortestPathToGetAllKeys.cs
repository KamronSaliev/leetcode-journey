using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/shortest-path-to-get-all-keys/
    /// </summary>
    public class Hard864_ShortestPathToGetAllKeys
    {
        public int ShortestPathAllKeys(string[] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;
            var allKeys = 0;
            var startX = 0;
            var startY = 0;
            var map = new char[rows, cols];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    var c = grid[i][j];

                    if (c == '@')
                    {
                        startX = i;
                        startY = j;
                    }

                    if (c is >= 'a' and <= 'f')
                    {
                        allKeys |= 1 << (c - 'a');
                    }

                    map[i, j] = c;
                }
            }

            var queue = new Queue<State>();
            var visited = new Dictionary<(int, int, int), int>();
            queue.Enqueue(new State(startX, startY, 0));
            visited[(startX, startY, 0)] = 0;

            int[] dx = { 0, 0, 1, -1 };
            int[] dy = { 1, -1, 0, 0 };

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.Keys == allKeys)
                {
                    return visited[(current.X, current.Y, current.Keys)];
                }

                for (var i = 0; i < 4; i++)
                {
                    var nx = current.X + dx[i];
                    var ny = current.Y + dy[i];
                    if (nx < 0 || ny < 0 || nx >= rows || ny >= cols)
                    {
                        continue;
                    }

                    var c = map[nx, ny];
                    var keys = current.Keys;

                    if (c == '#')
                    {
                        continue;
                    }

                    if (c is >= 'a' and <= 'f')
                    {
                        keys |= 1 << (c - 'a');
                    }

                    if (c is >= 'A' and <= 'F' && ((keys >> (c - 'A')) & 1) == 0)
                    {
                        continue;
                    }

                    if (visited.ContainsKey((nx, ny, keys)))
                    {
                        continue;
                    }

                    visited[(nx, ny, keys)] = visited[(current.X, current.Y, current.Keys)] + 1;
                    queue.Enqueue(new State(nx, ny, keys));
                }
            }

            return -1;
        }

        private class State
        {
            public int X { get; }
            public int Y { get; }
            public int Keys { get; }

            public State(int x, int y, int keys)
            {
                X = x;
                Y = y;
                Keys = keys;
            }
        }
    }
}