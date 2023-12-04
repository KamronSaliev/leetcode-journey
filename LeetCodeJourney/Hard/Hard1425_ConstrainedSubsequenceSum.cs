using System;
using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/constrained-subsequence-sum/
    /// </summary>
    public class Hard1425_ConstrainedSubsequenceSum
    {
        public int ConstrainedSubsetSum(int[] nums, int k)
        {
            var dp = new int[nums.Length];
            var result = nums[0];
            var deque = new LinkedList<int>();

            dp[0] = nums[0];
            deque.AddLast(0);

            for (var i = 1; i < nums.Length; i++)
            {
                while (deque.First != null && i - deque.First.Value > k)
                {
                    deque.RemoveFirst();
                }

                dp[i] = Math.Max(0, dp[deque.First.Value]) + nums[i];

                while (deque.Last != null && dp[i] >= dp[deque.Last.Value])
                {
                    deque.RemoveLast();
                }

                deque.AddLast(i);

                result = Math.Max(result, dp[i]);
            }

            return result;
        }
    }
}