using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/kth-largest-element-in-an-array/
    /// </summary>
    public class Medium215_KthLargestElementInAnArray
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var priorityQueue = new PriorityQueue<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                priorityQueue.Enqueue(nums[i], nums[i]);

                if (priorityQueue.Count > k)
                {
                    priorityQueue.Dequeue();
                }
            }

            return priorityQueue.Peek();
        }
    }
}