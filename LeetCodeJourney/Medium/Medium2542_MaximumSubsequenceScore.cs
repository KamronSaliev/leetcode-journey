using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-subsequence-score/
    /// </summary>
    public class Medium2542_MaximumSubsequenceScore
    {
        public long MaxScore(int[] nums1, int[] nums2, int k)
        {
            var nums = new List<Tuple<int, int>>();

            for (var i = 0; i < nums1.Length; i++)
            {
                nums.Add(new Tuple<int, int>(nums1[i], nums2[i]));
            }

            nums.Sort((x, y) => y.Item2.CompareTo(x.Item2));

            var priorityQueue = new PriorityQueue<int, int>();
            var sum = 0L;

            for (var i = 0; i < k; i++)
            {
                sum += nums[i].Item1;
                priorityQueue.Enqueue(nums[i].Item1, nums[i].Item1);
            }

            var result = sum * nums[k - 1].Item2;

            for (var i = k; i < nums2.Length; i++)
            {
                sum += nums[i].Item1 - priorityQueue.Dequeue();
                priorityQueue.Enqueue(nums[i].Item1, nums[i].Item1);
                result = Math.Max(result, sum * nums[i].Item2);
            }

            return result;
        }
    }
}