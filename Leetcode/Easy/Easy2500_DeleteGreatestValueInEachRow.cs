using System;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/delete-greatest-value-in-each-row/
    /// </summary>
    public class Easy2500_DeleteGreatestValueInEachRow
    {
        public int DeleteGreatestValue(int[][] grid)
        {
            for (var i = 0; i < grid.Length; i++)
            {
                Array.Sort(grid[i]);
            }

            var max = 0;
            var ans = 0;

            for (var i = 0; i < grid[0].Length; i++)
            {
                for (var j = 0; j < grid.Length; j++)
                {
                    if (grid[j][i] > max)
                    {
                        max = grid[j][i];
                    }
                }

                ans += max;
                max = 0;
            }

            return ans;
        }
    }
}