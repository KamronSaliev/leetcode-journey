using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/swapping-nodes-in-a-linked-list/
    /// </summary>
    public class Medium1721_SwappingNodesInALinkedList
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            ListNode node1 = null;
            ListNode node2 = null;

            for (var current = head; current != null; current = current.next)
            {
                node2 = node2?.next;

                if (--k != 0)
                {
                    continue;
                }

                node1 = current;
                node2 = head;
            }
            
            var value = node1.val;
            node1.val = node2.val;
            node2.val = value;

            return head;
        }
    }
}