using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/sum-of-square-numbers/
    /// </summary>
    public class Medium633_SumOfSquareNumbers
    {
        public bool JudgeSquareSum(int c)
        {
            var a = 0L;
            var b = (long)Math.Sqrt(c);

            while (a <= b)
            {
                if (a * a + b * b == c)
                {
                    return true;
                }

                if (a * a + b * b < c)
                {
                    a++;
                }
                else
                {
                    b--;
                }
            }

            return false;
        }
    }
}