using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/implement-queue-using-stacks/
    /// </summary>
    public class Easy232_ImplementQueueUsingStacks
    {
        /**
         * Your MyQueue object will be instantiated and called as such:
         * MyQueue obj = new MyQueue();
         * obj.Push(x);
         * int param_2 = obj.Pop();
         * int param_3 = obj.Peek();
         * bool param_4 = obj.Empty();
         */
        public class MyQueue
        {
            private readonly Stack<int> _stack;
            private readonly Stack<int> _temp;

            public MyQueue()
            {
                _stack = new Stack<int>();
                _temp = new Stack<int>();
            }

            public void Push(int x)
            {
                while (_stack.Count != 0)
                {
                    _temp.Push(_stack.Pop());
                }

                _temp.Push(x);

                while (_temp.Count != 0)
                {
                    _stack.Push(_temp.Pop());
                }
            }

            public int Pop()
            {
                return _stack.Pop();
            }

            public int Peek()
            {
                return _stack.Peek();
            }

            public bool Empty()
            {
                return _stack.Count == 0;
            }
        }
    }
}