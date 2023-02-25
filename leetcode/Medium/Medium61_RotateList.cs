using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/rotate-list/
    /// </summary>
    public class Medium61_RotateList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }

            var length = 1;
            var tail = head;

            while (tail.next != null)
            {
                length++;
                tail = tail.next;
            }

            tail.next = head;

            k = length - k % length;

            for (var i = 0; i < k; i++)
            {
                head = head.next;
                tail = tail.next;
            }

            tail.next = null;

            return head;
        }
    }
}