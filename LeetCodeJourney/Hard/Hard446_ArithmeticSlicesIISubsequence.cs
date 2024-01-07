using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/arithmetic-slices-ii-subsequence/
    /// </summary>
    public class Hard446_ArithmeticSlicesIISubsequence
    {
        public int NumberOfArithmeticSlices(int[] nums)
        {
            var n = nums.Length;
            var dp = new Dictionary<int, int>[n];
            var result = 0;

            for (var i = 0; i < n; i++)
            {
                dp[i] = new Dictionary<int, int>();

                for (var j = 0; j < i; j++)
                {
                    var delta = (long)nums[i] - nums[j];

                    if (delta is <= int.MinValue or > int.MaxValue)
                    {
                        continue;
                    }

                    var difference = (int)delta;
                    var sum = dp[j].GetValueOrDefault(difference);
                    var origin = dp[i].GetValueOrDefault(difference);

                    dp[i][difference] = origin + sum + 1;
                    result += sum;
                }
            }

            return result;
        }
    }
}