using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-one-bit-operations-to-make-integers-zero/
    /// </summary>
    public class Hard1611_MinimumOneBitOperationsToMakeIntegersZero
    {
        public int MinimumOneBitOperations(int n)
        {
            var binaryValue = Convert.ToString(n, 2);
            var result = "" + binaryValue[0];
            
            for (var i = 1; i < binaryValue.Length; i++)
            {
                result += int.Parse(binaryValue[i].ToString()) ^ int.Parse(result[i - 1].ToString());
            }

            return Convert.ToInt32(result, 2);
        }
    }
}