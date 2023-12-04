namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/last-day-where-you-can-still-cross/
    /// </summary>
    public class Hard1970_LastDayWhereYouCanStillCross
    {
        private readonly int[][] _directions =
        {
            new[] { 1, 0 },
            new[] { -1, 0 },
            new[] { 0, 1 },
            new[] { 0, -1 }
        };

        public int LatestDayToCross(int row, int col, int[][] cells)
        {
            var left = 1;
            var right = cells.Length - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (CanCross(mid, row, col, cells))
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }

        private bool CanCross(int index, int rows, int cols, int[][] cells)
        {
            var visited = new bool[rows, cols];

            for (var i = 0; i <= index; i++)
            {
                visited[cells[i][0] - 1, cells[i][1] - 1] = true;
            }

            for (var c = 0; c < cols; c++)
            {
                if (DFS(0, c, rows, cols, visited))
                {
                    return true;
                }
            }

            return false;
        }

        private bool DFS(int r, int c, int rows, int cols, bool[,] visited)
        {
            if (r < 0 || r >= rows || c < 0 || c >= cols || visited[r, c])
            {
                return false;
            }

            if (r == rows - 1)
            {
                return true;
            }

            visited[r, c] = true;

            foreach (var direction in _directions)
            {
                if (DFS(r + direction[0], c + direction[1], rows, cols, visited))
                {
                    return true;
                }
            }

            return false;
        }
    }
}