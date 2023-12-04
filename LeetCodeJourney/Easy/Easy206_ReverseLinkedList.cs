using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/reverse-linked-list/
    /// </summary>
    public class Easy206_ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode current = null;

            while (head != null)
            {
                var next = head.next;
                head.next = current;
                current = head;
                head = next;
            }

            return current;
        }
    }
}