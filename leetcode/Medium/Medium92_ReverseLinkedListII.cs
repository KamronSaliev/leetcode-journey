using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/reverse-linked-list-ii/
    /// </summary>
    public class Medium92_ReverseLinkedListII
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            var dummy = new ListNode();
            var previous = dummy;

            dummy.next = head;

            for (var i = 0; i < left - 1; i++)
            {
                previous = previous.next;
            }

            var current = previous.next;

            for (var i = 0; i < right - left; ++i)
            {
                var next = current.next;
                current.next = next.next;
                next.next = previous.next;
                previous.next = next;
            }

            return dummy.next;
        }
    }
}