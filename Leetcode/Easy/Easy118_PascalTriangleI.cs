using System.Collections.Generic;
using Leetcode.Utilities;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/pascals-triangle/
    /// </summary>
    public class Easy118_PascalTriangleI
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var ans = new List<IList<int>>();

            for (var i = 0; i < numRows; i++)
            {
                var list = new List<int>();

                for (var j = 0; j <= i; j++)
                {
                    list.Add((int)LeetcodeUtilities.GetBinomialCoefficientOptimized(i, j));
                }

                ans.Add(list);
            }

            return ans;
        }
    }
}