using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/rotting-oranges/
    /// </summary>
    public class Medium994_RottingOranges
    {
        private readonly Queue<Coordinate> _rottenQueue = new();
        private int _total;
        private int _rotten;
        private int _time;

        private readonly List<Coordinate> _directions = new()
        {
            new Coordinate(-1, 0), new Coordinate(1, 0), new Coordinate(0, -1), new Coordinate(0, 1)
        };

        public int OrangesRotting(int[][] grid)
        {
            Init(grid);

            if (_total == 0)
            {
                return 0;
            }

            while (_rottenQueue.Count != 0 && _rotten < _total)
            {
                var size = _rottenQueue.Count;
                _rotten += size;

                if (_rotten == _total)
                {
                    return _time;
                }

                _time++;

                for (var i = 0; i < size; i++)
                {
                    UpdateAdjacent(grid);
                }
            }

            return -1;
        }

        private void Init(int[][] grid)
        {
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1 || grid[i][j] == 2)
                    {
                        _total++;
                    }

                    if (grid[i][j] == 2)
                    {
                        _rottenQueue.Enqueue(new Coordinate(i, j));
                    }
                }
            }
        }

        private void UpdateAdjacent(int[][] grid)
        {
            var currentCoordinate = _rottenQueue.Dequeue();

            for (var j = 0; j < _directions.Count; j++)
            {
                var tempX = currentCoordinate.X + _directions[j].X;
                var tempY = currentCoordinate.Y + _directions[j].Y;

                if (tempX < 0 || tempX >= grid.Length || tempY < 0 || tempY >= grid[0].Length ||
                    grid[tempX][tempY] != 1)
                {
                    continue;
                }

                grid[tempX][tempY] = 2;
                _rottenQueue.Enqueue(new Coordinate(tempX, tempY));
            }
        }
    }
}