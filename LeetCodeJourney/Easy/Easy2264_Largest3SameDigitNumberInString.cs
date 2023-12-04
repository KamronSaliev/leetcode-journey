using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/largest-3-same-digit-number-in-string/
    /// </summary>
    public class Easy2264_Largest3SameDigitNumberInString
    {
        public string LargestGoodInteger(string num)
        {
            var result = -1;

            for (var i = 0; i < num.Length - 2; i++)
            {
                if (num[i] == num[i + 1] && num[i] == num[i + 2])
                {
                    var current = int.Parse(num.Substring(i, 3));
                    result = Math.Max(result, current);
                }
            }

            if (result == -1)
            {
                return string.Empty;
            }

            return result == 0 ? "000" : result.ToString();
        }
    }
}