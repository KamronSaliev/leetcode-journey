using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/pascals-triangle/
    /// </summary>
    public class Easy118_PascalTriangleI
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();

            for (var i = 0; i < numRows; i++)
            {
                var list = new List<int>();

                for (var j = 0; j <= i; j++)
                {
                    list.Add((int)CommonUtilities.GetBinomialCoefficientOptimized(i, j));
                }

                result.Add(list);
            }

            return result;
        }
    }
}