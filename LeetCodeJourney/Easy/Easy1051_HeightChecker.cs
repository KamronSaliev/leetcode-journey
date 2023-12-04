using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/height-checker/
    /// </summary>
    public class Easy1051_HeightChecker
    {
        public int HeightChecker(int[] heights)
        {
            var expected = new int[heights.Length];
            var result = 0;

            for (var i = 0; i < heights.Length; i++)
            {
                expected[i] = heights[i];
            }

            Array.Sort(expected);

            for (var i = 0; i < heights.Length; i++)
            {
                if (expected[i] != heights[i])
                {
                    result++;
                }
            }

            return result;
        }
    }
}