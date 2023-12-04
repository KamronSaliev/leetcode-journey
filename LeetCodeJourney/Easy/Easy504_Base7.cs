using System;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/base-7/
    /// </summary>
    public class Easy504_Base7
    {
        public string ConvertToBase7(int num)
        {
            var nums = string.Empty;
            var sign = string.Empty;
            var baseNum = 7;

            if (num == 0)
            {
                return num.ToString();
            }

            if (num < 0)
            {
                num = Math.Abs(num);
                sign += "-";
            }

            while (num != 0)
            {
                var remainder = num % baseNum;
                num /= baseNum;
                nums += remainder;
            }

            nums = new string(nums.Reverse().ToArray());

            return sign + nums;
        }
    }
}