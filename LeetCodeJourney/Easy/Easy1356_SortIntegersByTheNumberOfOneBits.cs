using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/sort-integers-by-the-number-of-1-bits/
    /// </summary>
    public class Easy1356_SortIntegersByTheNumberOfOneBits
    {
        public int[] SortByBits(int[] arr)
        {
            return arr.OrderBy(GetNumberOfOneBits).ThenBy(num => num).ToArray();
        }

        private int GetNumberOfOneBits(int num)
        {
            var count = 0;

            while (num != 0)
            {
                count += num % 2;
                num /= 2;
            }

            return count;
        }
    }
}