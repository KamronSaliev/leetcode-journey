using Leetcode.Utilities;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/middle-of-the-linked-list/
    /// </summary>
    public class Easy876_MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            var n = 0;
            var start = head;

            while (head != null)
            {
                n++;
                head = head.next;
            }

            head = start;

            for (var i = 0; i < n / 2; i++)
            {
                head = head.next;
            }

            return head;
        }
    }
}