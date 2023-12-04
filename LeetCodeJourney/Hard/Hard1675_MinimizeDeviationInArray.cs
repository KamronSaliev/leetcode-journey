using System;
using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/minimize-deviation-in-array/
    /// </summary>
    public class Hard1675_MinimizeDeviationInArray
    {
        public int MinimumDeviation(int[] nums)
        {
            var minValue = int.MaxValue;
            var minDeviation = int.MaxValue;

            var priorityQueue = new PriorityQueue<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    nums[i] *= 2;
                }

                minValue = Math.Min(minValue, nums[i]);
                priorityQueue.Enqueue(nums[i], -nums[i]);
            }

            while (priorityQueue.Peek() % 2 == 0)
            {
                var maxValue = priorityQueue.Dequeue();
                minDeviation = Math.Min(minDeviation, maxValue - minValue);
                var newValue = maxValue / 2;
                priorityQueue.Enqueue(newValue, -newValue);
                minValue = Math.Min(minValue, newValue);
            }

            return Math.Min(minDeviation, priorityQueue.Peek() - minValue);
        }
    }
}