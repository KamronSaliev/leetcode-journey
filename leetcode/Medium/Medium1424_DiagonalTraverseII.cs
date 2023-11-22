using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/diagonal-traverse-ii/description/
    /// </summary>
    public class Medium1424_DiagonalTraverseII
    {
        public int[] FindDiagonalOrder(IList<IList<int>> nums)
        {
            var dictionary = new Dictionary<int, List<int>>();

            for (var i = 0; i < nums.Count; i++)
            {
                for (var j = 0; j < nums[i].Count; j++)
                {
                    var diagonal = i + j;

                    if (!dictionary.ContainsKey(diagonal))
                    {
                        dictionary[diagonal] = new List<int>();
                    }

                    dictionary[diagonal].Insert(0, nums[i][j]);
                }
            }

            var result = new List<int>();

            foreach (var numbers in dictionary)
            {
                result.AddRange(numbers.Value);
            }

            return result.ToArray();
        }
    }
}