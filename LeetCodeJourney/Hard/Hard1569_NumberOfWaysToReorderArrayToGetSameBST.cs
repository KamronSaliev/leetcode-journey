using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-ways-to-reorder-array-to-get-same-bst/
    /// </summary>
    public class Hard1569_NumberOfWaysToReorderArrayToGetSameBST
    {
        private long[][] _table;

        private const int Mod = (int)(1e9 + 7);

        public int NumOfWays(int[] nums)
        {
            FormPascalTriangle(nums.Length);

            return (int)DFS(nums.ToList()) - 1;
        }

        private long DFS(List<int> nums)
        {
            var n = nums.Count;

            if (n <= 2)
            {
                return 1;
            }

            var smaller = new List<int>();
            var greater = new List<int>();

            for (var i = 1; i < n; i++)
            {
                if (nums[i] < nums[0])
                {
                    smaller.Add(nums[i]);
                }
                else
                {
                    greater.Add(nums[i]);
                }
            }

            return _table[n - 1][smaller.Count] * (DFS(smaller) % Mod) % Mod * DFS(greater) % Mod;
        }


        private void FormPascalTriangle(int n)
        {
            _table = new long[n][];

            for (var i = 0; i < n; i++)
            {
                _table[i] = new long[n];
            }

            for (var i = 0; i < n; i++)
            {
                _table[i][0] = 1;
                _table[i][i] = 1;
            }

            for (var i = 2; i < n; i++)
            {
                for (var j = 1; j < i; j++)
                {
                    _table[i][j] = (_table[i - 1][j] + _table[i - 1][j - 1]) % Mod;
                }
            }
        }
    }
}