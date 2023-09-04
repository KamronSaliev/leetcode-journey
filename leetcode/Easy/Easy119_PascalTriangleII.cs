using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/pascals-triangle-ii/
    /// </summary>
    public class Easy119_PascalTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            var result = new int[rowIndex + 1];
            result[0] = 1;

            for (var i = 0; i <= rowIndex; i++)
            {
                for (var j = i; j > 0; j--)
                {
                    result[j] += result[j - 1];
                }
            }

            return result;
        }
    }
}