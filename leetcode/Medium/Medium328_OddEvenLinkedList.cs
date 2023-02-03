using Leetcode.Utilities;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/odd-even-linked-list/
    /// </summary>
    public class Medium328_OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            
            var odd = head;
            var even = head.next;
            var evenStart = head.next;

            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }

            odd.next = evenStart;

            return head;
        }
    }
}