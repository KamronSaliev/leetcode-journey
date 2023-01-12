using System.Collections.Generic;
using Leetcode.Utilities;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/pascals-triangle-ii/
    /// </summary>
    public class Easy119_PascalTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            var ans = new List<int> { 1 };

            var index = 0;

            while (index <= rowIndex)
            {
                ans.Clear();

                for (var j = 0; j <= index; j++)
                {
                    ans.Add((int)CommonUtilities.GetBinomialCoefficientOptimized(index, j));
                }

                index++;
            }

            return ans;
        }
    }
}