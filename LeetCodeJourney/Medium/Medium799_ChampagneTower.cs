using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/champagne-tower/
    /// </summary>
    public class Medium799_ChampagneTower
    {
        public double ChampagneTower(int poured, int queryRow, int queryGlass)
        {
            var tower = new double[queryRow + 1][];

            for (var i = 0; i <= queryRow; i++)
            {
                tower[i] = new double[i + 1];
            }

            tower[0][0] = poured;

            for (var row = 0; row < queryRow; row++)
            {
                for (var glass = 0; glass < tower[row].Length; glass++)
                {
                    var excess = (tower[row][glass] - 1) / 2.0f;

                    if (excess > 0)
                    {
                        tower[row + 1][glass] += excess;
                        tower[row + 1][glass + 1] += excess;
                    }
                }
            }

            return Math.Min(1.0f, tower[queryRow][queryGlass]);
        }
    }
}