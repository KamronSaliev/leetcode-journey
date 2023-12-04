using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/kth-largest-element-in-a-stream/
    /// </summary>
    public class Easy703_KthLargestElementInAStream
    {
        /**
         * Your KthLargest object will be instantiated and called as such:
         * KthLargest obj = new KthLargest(k, nums);
         * int param_1 = obj.Add(val);
         */
        public class KthLargest
        {
            private readonly PriorityQueue<int, int> _priorityQueue;
            private readonly int _k;

            public KthLargest(int k, int[] nums)
            {
                _k = k;
                _priorityQueue = new PriorityQueue<int, int>();

                for (var i = 0; i < nums.Length; i++)
                {
                    Add(nums[i]);
                }
            }

            public int Add(int val)
            {
                _priorityQueue.Enqueue(val, val);

                while (_priorityQueue.Count > _k)
                {
                    _priorityQueue.Dequeue();
                }

                return _priorityQueue.Peek();
            }
        }
    }
}