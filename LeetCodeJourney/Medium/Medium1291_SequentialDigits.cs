using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/sequential-digits/
    /// </summary>
    public class Medium1291_SequentialDigits
    {
        public IList<int> SequentialDigits(int low, int high)
        {
            var result = new List<int>();

            for (var digit = 1; digit < 9; digit++)
            {
                var num = digit;
                var nextDigit = num + 1;

                while (num <= high && nextDigit <= 9)
                {
                    num = num * 10 + nextDigit;
                    
                    if (num >= low && num <= high)
                    {
                        result.Add(num);
                    }

                    nextDigit++;
                }
            }

            result.Sort();
            return result;
        }
    }
}