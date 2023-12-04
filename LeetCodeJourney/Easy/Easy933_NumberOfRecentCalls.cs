using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-recent-calls/
    /// </summary>
    public class Easy933_NumberOfRecentCalls
    {
        /**
         * Your RecentCounter object will be instantiated and called as such:
         * RecentCounter obj = new RecentCounter();
         * int param_1 = obj.Ping(t);
         */
        public class RecentCounter
        {
            private readonly Queue<int> _queue;
            private const int Interval = 3000;

            public RecentCounter()
            {
                _queue = new Queue<int>();
            }

            public int Ping(int t)
            {
                _queue.Enqueue(t);
                
                while (_queue.Peek() < t - Interval)
                {
                    _queue.Dequeue();
                }

                return _queue.Count;
            }
        }
    }
}