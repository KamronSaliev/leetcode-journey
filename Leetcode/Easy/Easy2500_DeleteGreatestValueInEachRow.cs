using System;

namespace Leetcode.Easy
{
    public class Easy2500_DeleteGreatestValueInEachRow
    {
        public int DeleteGreatestValue(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                Array.Sort(grid[i]);
            }

            var max = 0;
            var ans = 0;

            for (int i = 0; i < grid[0].Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
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