using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list
    /// </summary>
    public class Medium2095_DeleteTheMiddleNodeOfALinkedList
    {
        public ListNode DeleteMiddle(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var dummy = new ListNode
            {
                next = head
            };
            
            var slow = dummy;
            var fast = head;
            
            while (fast is { next: not null })
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            slow.next = slow.next.next;
            
            return dummy.next;
        }
    }
}