using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
    /// </summary>
    public class Easy1281_SubtractTheProductAndSumOfDigitsOfAnInteger
    {
        public int SubtractProductAndSum(int n)
        {
            var digits = new List<int>();

            while (n != 0)
            {
                digits.Add(n % 10);
                n /= 10;
            }

            var sum = 0L;
            var product = 1L;

            for (int i = 0; i < digits.Count; i++)
            {
                sum += digits[i];
                product *= digits[i];
            }

            return (int)(product - sum);
        }
    }
}