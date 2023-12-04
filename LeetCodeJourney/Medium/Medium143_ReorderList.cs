using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/reorder-list/
    /// </summary>
    public class Medium143_ReorderList
    {
        public void ReorderList(ListNode head)
        {
            var length = GetLength(head);
            if (length < 2)
            {
                return;
            }

            var secondHalf = new Stack<ListNode>();
            var current = head;
            var k = length / 2;

            for (var i = 0; i < length; i++)
            {
                k--;

                if (k < 0)
                {
                    secondHalf.Push(current);
                }

                current = current.next;
            }

            current = head;

            while (current != null && secondHalf.Count > 0)
            {
                var next = current.next;
                current.next = secondHalf.Pop();
                current = current.next;
                current.next = next;
                current = current.next;
            }

            if (current != null)
            {
                current.next.next = null;
            }
        }

        private int GetLength(ListNode head)
        {
            var length = 1;

            while (head.next != null)
            {
                length++;
                head = head.next;
            }

            return length;
        }
    }
}