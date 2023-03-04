using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/split-with-minimum-sum/description/
    /// </summary>
    public class Easy2578_SplitWithMinimumSum
    {
        public int SplitNum(int num)
        {
            var digits = new List<int>();

            while (num != 0)
            {
                digits.Add(num % 10);
                num /= 10;
            }

            digits.Sort();

            var num1 = 0;
            var num2 = 0;

            for (var i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    num1 = num1 * 10 + digits[i];
                }
                else
                {
                    num2 = num2 * 10 + digits[i];
                }
            }

            return num1 + num2;
        }
    }
}