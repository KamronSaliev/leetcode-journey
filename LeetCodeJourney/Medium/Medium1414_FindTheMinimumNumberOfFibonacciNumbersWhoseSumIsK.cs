using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-the-minimum-number-of-fibonacci-numbers-whose-sum-is-k/
    /// </summary>
    public class Medium1414_FindTheMinimumNumberOfFibonacciNumbersWhoseSumIsK
    {
        public int FindMinFibonacciNumbers(int k)
        {
            var list = new List<int> { 1, 1 };
            var num = 1;

            while (num <= k)
            {
                num = list[list.Count - 1] + list[list.Count - 2];
                list.Add(num);
            }

            var counter = 0;

            while (k > 0)
            {
                for (var i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i] > k)
                    {
                        continue;
                    }

                    k -= list[i];
                    counter++;
                }
            }

            return counter;
        }
    }
}