using System;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-value-of-a-string-in-an-array/
    /// </summary>
    public class Easy2496_MaximumValueOfAStringInAnArray
    {
        public int MaximumValue(string[] strs)
        {
            var max = -1;

            for (var i = 0; i < strs.Length; i++)
            {
                var currentValue = CheckValue(strs[i]);
                if (currentValue > max)
                {
                    max = currentValue;
                }
            }

            return max;
        }

        private int CheckValue(string str)
        {
            for (var i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    return str.Length;
                }
            }

            return Convert.ToInt32(str);
        }
    }
}