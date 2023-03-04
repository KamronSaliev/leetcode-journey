namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/count-total-number-of-colored-cells/description/
    /// </summary>
    public class Medium2579_CountTotalNumberOfColoredCells
    {
        public long ColoredCells(int n)
        {
            var horizontalLine = 2 * n - 1;

            // central cell is excluded
            var verticalLine = 2 * n - 2;

            // sum of cells on 4 sides with excluded central horizontal and vertical lines as borders
            var sides = 4 * Sum(n - 2);
            return horizontalLine + verticalLine + sides;
        }

        private long Sum(long n)
        {
            return n * (n + 1) / 2;
        }
    }
}