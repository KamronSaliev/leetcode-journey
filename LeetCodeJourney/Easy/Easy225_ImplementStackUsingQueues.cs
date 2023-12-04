using System.Collections.Generic;

namespace LeetCode.Easy
{
    public class Easy225_ImplementStackUsingQueues
    {
        /**
         * Your MyStack object will be instantiated and called as such:
         * MyStack obj = new MyStack();
         * obj.Push(x);
         * int param_2 = obj.Pop();
         * int param_3 = obj.Top();
         * bool param_4 = obj.Empty();
         */
        public class MyStack
        {
            private readonly Queue<int> _queue = new();

            public void Push(int x)
            {
                _queue.Enqueue(x);
                
                for (var i = 0; i < _queue.Count - 1; i++)
                {
                    _queue.Enqueue(_queue.Dequeue());
                }
            }

            public int Pop()
            {
                return _queue.Dequeue();
            }

            public int Top()
            {
                return _queue.Peek();
            }

            public bool Empty()
            {
                return _queue.Count == 0;
            }
        }
    }
}