using System;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/linked-list-random-node/
    /// </summary>
    public class Medium382_LinkedListRandomNode
    {
        /**
         * Your Solution object will be instantiated and called as such:
         * Solution obj = new Solution(head);
         * int param_1 = obj.GetRandom();
         */
        public class Solution
        {
            private readonly ListNode _head;
            private readonly Random _rand;
            private readonly int _count;

            public Solution(ListNode head)
            {
                _head = head;
                _rand = new Random();

                var current = head;

                while (current != null)
                {
                    _count++;
                    current = current.next;
                }
            }

            public int GetRandom()
            {
                var current = _head;
                var randomIndex = _rand.Next(_count);

                for (var i = 0; i < randomIndex; i++)
                {
                    current = current.next;
                }

                return current.val;
            }
        }
    }
}