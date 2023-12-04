using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/min-stack/
    /// </summary>
    public class Medium155_MinStack
    {
        /**
         * Your MinStack object will be instantiated and called as such:
         * MinStack obj = new MinStack();
         * obj.Push(val);
         * obj.Pop();
         * int param_3 = obj.Top();
         * int param_4 = obj.GetMin();
         */
        public class MinStack
        {
            private MinNode _head;

            public void Push(int val)
            {
                _head = _head == null
                    ? new MinNode(val, val, _head)
                    : new MinNode(val, Math.Min(val, _head.min), _head);
            }

            public void Pop()
            {
                _head = _head.next;
            }

            public int Top()
            {
                return _head.val;
            }

            public int GetMin()
            {
                return _head.min;
            }

            public class MinNode
            {
                public int val;
                public int min;
                public MinNode next;

                public MinNode(int val, int min, MinNode next)
                {
                    this.val = val;
                    this.min = min;
                    this.next = next;
                }
            }
        }
    }
}