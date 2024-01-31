using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/daily-temperatures/
    /// </summary>
    public class Medium739_DailyTemperatures
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var n = temperatures.Length;
            var result = new int[n];
            var stack = new Stack<int>();

            for (var i = n - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && temperatures[i] >= temperatures[stack.Peek()])
                {
                    stack.Pop();
                }
                
                result[i] = stack.Count == 0 ? 0 : stack.Peek() - i;
                stack.Push(i);
            }

            return result;
        }
    }
}