using Leetcode.Utilities;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    /// </summary>
    public class Medium19_RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var len = 0;
            var start = head;

            while (head != null)
            {
                head = head.next;
                len++;
            }

            if (len == n)
            {
                return start.next;
            }

            head = start;

            for (var i = 0; i < len - n - 1; i++)
            {
                head = head.next;
            }

            head.next = head.next.next;

            return start;
        }
    }
}