namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/out-of-boundary-paths/
    /// </summary>
    public class Medium576_OutOfBoundaryPaths
    {
        private const int Mod = (int)1e9 + 7;
        private int _m, _n;

        public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
        {
            _m = m;
            _n = n;
            
            var dp = new int[m, n, maxMove + 1];

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    for (var k = 0; k <= maxMove; k++)
                    {
                        dp[i, j, k] = -1;
                    }
                }
            }

            return DFS(maxMove, startRow, startColumn, dp);
        }

        private int DFS(int maxMove, int x, int y, int[,,] dp)
        {
            if (IsOutsideGrid(x, y))
            {
                return 1;
            }

            if (maxMove <= 0)
            {
                return 0;
            }

            if (dp[x, y, maxMove] != -1)
            {
                return dp[x, y, maxMove];
            }
            
            var result = 0;

            result = (result + DFS(maxMove - 1, x + 1, y, dp)) % Mod;
            result = (result + DFS(maxMove - 1, x, y - 1, dp)) % Mod;
            result = (result + DFS(maxMove - 1, x - 1, y, dp)) % Mod;
            result = (result + DFS(maxMove - 1, x, y + 1, dp)) % Mod;

            dp[x, y, maxMove] = result;

            return result;
        }
        
        private bool IsOutsideGrid(int x, int y)
        {
            return x < 0 || x >= _m || y < 0 || y >= _n;
        }
    }
}