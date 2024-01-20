using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/sum-of-subarray-minimums/
    /// </summary>
    public class Medium907_SumOfSubarrayMinimums
    {
        public int SumSubarrayMins(int[] arr)
        {
            const int mod = (int)1e9 + 7;

            var n = arr.Length;
            var result = 0L;
            var stack = new Stack<int>();

            for (var i = 0; i <= n; i++)
            {
                while (stack.Count > 0 && (i == n || arr[i] < arr[stack.Peek()]))
                {
                    var current = stack.Pop();
                    var left = stack.Count > 0 ? stack.Peek() : -1;
                    result = (result + (long)arr[current] * (i - current) * (current - left)) % mod;
                }

                if (i < n)
                {
                    stack.Push(i);
                }
            }

            return (int)result;
        }
    }
}