using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/convert-an-array-into-a-2d-array-with-conditions/
    /// </summary>
    public class Medium2610_ConvertAnArrayIntoA2DArrayWithConditions
    {
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            var result = new List<IList<int>> { new List<int>() };
            var dictionary = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (!dictionary.TryAdd(num, 0) && result.Count <= ++dictionary[num])
                {
                    result.Add(new List<int>());
                }

                result[dictionary[num]].Add(num);
            }

            return result;
        }
    }
}