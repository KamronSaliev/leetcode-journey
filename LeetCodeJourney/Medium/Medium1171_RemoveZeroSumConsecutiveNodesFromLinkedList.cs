using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/remove-zero-sum-consecutive-nodes-from-linked-list/
    /// </summary>
    public class Medium1171_RemoveZeroSumConsecutiveNodesFromLinkedList
    {
        public ListNode RemoveZeroSumSublists(ListNode head)
        {
            var dictionary = new Dictionary<int, ListNode>();
            var dummy = new ListNode(0, head);
            var current = dummy;
            var sum = 0;

            while (current != null)
            {
                sum += current.val;
                dictionary[sum] = current;
                current = current.next;
            }

            current = dummy;
            sum = 0;

            while (current != null)
            {
                sum += current.val;
                current.next = dictionary[sum].next;
                current = current.next;
            }

            return dummy.next;
        }
    }
}