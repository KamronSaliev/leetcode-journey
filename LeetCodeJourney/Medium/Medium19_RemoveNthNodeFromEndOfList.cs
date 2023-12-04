using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    /// </summary>
    public class Medium19_RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var length = 0;
            var start = head;

            while (head != null)
            {
                head = head.next;
                length++;
            }

            if (length == n)
            {
                return start.next;
            }

            head = start;

            for (var i = 0; i < length - n - 1; i++)
            {
                head = head.next;
            }

            head.next = head.next.next;

            return start;
        }
    }
}