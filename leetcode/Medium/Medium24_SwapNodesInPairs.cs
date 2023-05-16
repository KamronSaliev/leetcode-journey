using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/swap-nodes-in-pairs/
    /// </summary>
    public class Medium24_SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            var dummy = new ListNode();
            var previous = dummy;
            var current = head;
            
            dummy.next = current;

            while (current is { next: not null })
            {
                previous.next = current.next;
                current.next = current.next.next;
                previous.next.next = current;
                previous = current;
                current = current.next;
            }

            return dummy.next;
        }
    }
}