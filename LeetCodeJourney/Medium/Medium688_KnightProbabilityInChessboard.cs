namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/knight-probability-in-chessboard/
    /// </summary>
    public class Medium688_KnightProbabilityInChessboard
    {
        private readonly (int, int)[] _knightMoves =
            { (-2, -1), (-2, 1), (-1, -2), (-1, 2), (1, -2), (1, 2), (2, -1), (2, 1) };

        public double KnightProbability(int n, int k, int row, int column)
        {
            var current = new double[n, n];
            current[row, column] = 1;

            for (var i = 0; i < k; ++i)
            {
                current = NextMove(current, n);
            }

            return SumProbability(current);
        }

        private double[,] NextMove(double[,] previous, int n)
        {
            var current = new double[n, n];

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (previous[i, j] == 0)
                    {
                        continue;
                    }

                    foreach ((int R, int C) move in _knightMoves)
                    {
                        var newR = i + move.R;
                        var newC = j + move.C;

                        if (CheckValidMove(n, newR, newC))
                        {
                            current[newR, newC] += previous[i, j] / 8;
                        }
                    }
                }
            }

            return current;
        }

        private bool CheckValidMove(int n, int r, int c)
        {
            return r >= 0 && r < n && c >= 0 && c < n;
        }

        private double SumProbability(double[,] arr)
        {
            var sum = 0d;
            
            foreach (var num in arr)
            {
                sum += num;
            }

            return sum;
        }
    }
}