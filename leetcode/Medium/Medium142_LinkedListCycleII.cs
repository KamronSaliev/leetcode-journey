using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/linked-list-cycle-ii/
    /// </summary>
    public class Medium142_LinkedListCycleII
    {
        public ListNode DetectCycle(ListNode head)
        {
            var nodes = new HashSet<ListNode>();

            while (head != null)
            {
                if (nodes.Contains(head.next))
                {
                    return head.next;
                }

                nodes.Add(head);

                head = head.next;
            }

            return null;
        }
    }
}