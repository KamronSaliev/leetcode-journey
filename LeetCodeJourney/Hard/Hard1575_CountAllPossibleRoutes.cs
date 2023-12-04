using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/count-all-possible-routes/
    /// </summary>
    public class Hard1575_CountAllPossibleRoutes
    {
        private const int Mod = (int)(1e9 + 7);

        private int[,] _dp;
        private int[] _locations;

        public int CountRoutes(int[] locations, int start, int finish, int fuel)
        {
            _locations = locations;
            _dp = new int[locations.Length, fuel + 1];

            for (var i = 0; i < locations.Length; i++)
            {
                for (var j = 0; j < fuel + 1; j++)
                {
                    _dp[i, j] = -1;
                }
            }

            return DFS(start, finish, fuel);
        }

        private int DFS(int i, int finish, int fuel)
        {
            if (fuel < 0)
            {
                return 0;
            }

            if (_dp[i, fuel] != -1)
            {
                return _dp[i, fuel];
            }

            var result = 0;

            if (i == finish)
            {
                result++;
            }

            for (var j = 0; j < _locations.Length; j++)
            {
                if (j == i)
                {
                    continue;
                }

                result = (result + DFS(j, finish, fuel - Math.Abs(_locations[i] - _locations[j]))) % Mod;
            }

            return _dp[i, fuel] = result;
        }
    }
}