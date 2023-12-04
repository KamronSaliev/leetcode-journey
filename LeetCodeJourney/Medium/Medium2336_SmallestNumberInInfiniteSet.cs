using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/smallest-number-in-infinite-set/
    /// </summary>
    public class Medium2336_SmallestNumberInInfiniteSet
    {
        /**
         * Your SmallestInfiniteSet object will be instantiated and called as such:
         * SmallestInfiniteSet obj = new SmallestInfiniteSet();
         * int param_1 = obj.PopSmallest();
         * obj.AddBack(num);
         */
        public class SmallestInfiniteSet
        {
            private readonly PriorityQueue<int, int> _set;

            private const int Max = 1000;

            public SmallestInfiniteSet()
            {
                _set = new PriorityQueue<int, int>();

                for (var i = 1; i <= Max; i++)
                {
                    _set.Enqueue(i, i);
                }
            }

            public int PopSmallest()
            {
                var smallest = _set.Dequeue();

                while (_set.Count != 0)
                {
                    if (_set.Peek() == smallest)
                    {
                        _set.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                }

                return smallest;
            }

            public void AddBack(int num)
            {
                _set.Enqueue(num, num);
            }
        }
    }
}