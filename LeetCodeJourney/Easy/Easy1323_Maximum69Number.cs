using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-69-number/
    /// </summary>
    public class Easy1323_Maximum69Number
    {
        public int Maximum69Number(int num)
        {
            var index = -1;
            var tempNumber = num;

            for (var i = 0; tempNumber > 0; i++)
            {
                if (tempNumber % 10 == 6)
                {
                    index = i;
                }

                tempNumber /= 10;
            }

            return (int)(num + 3 * Math.Pow(10, index));
        }
    }
}