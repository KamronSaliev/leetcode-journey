namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/
    /// </summary>
    public class Easy1351_CountNegativeNumbersInASortedMatrix
    {
        public int CountNegatives(int[][] grid)
        {
            var count = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                count += CountRow(grid[i]);
            }

            return count;
        }

        private int CountRow(int[] row)
        {
            var left = 0;
            var right = row.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (row[mid] < 0)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return row.Length - left;
        }
    }
}