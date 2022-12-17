using System;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/sign-of-the-product-of-an-array/
    /// </summary>
    public class Easy1822_SignOfTheProductOfAnArray
    {
        public int ArraySign(int[] nums)
        {
            var negNumCounter = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    return 0;
                }

                if (nums[i] < 0)
                {
                    negNumCounter++;
                }
            }

            Console.WriteLine();

            return negNumCounter % 2 == 0 ? 1 : -1;
        }
    }
}