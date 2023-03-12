using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/merge-k-sorted-lists/
    /// </summary>
    public class Hard23_MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var priorityQueue = new PriorityQueue<ListNode, int>();

            for (var i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null)
                {
                    priorityQueue.Enqueue(lists[i], lists[i].val);
                }
            }

            var dummy = new ListNode();
            var current = dummy;

            while (priorityQueue.Count != 0)
            {
                var node = priorityQueue.Dequeue();

                if (node.next != null)
                {
                    priorityQueue.Enqueue(node.next, node.next.val);
                }

                current.next = new ListNode(node.val);
                current = current.next;
            }

            return dummy.next;
        }
    }
}