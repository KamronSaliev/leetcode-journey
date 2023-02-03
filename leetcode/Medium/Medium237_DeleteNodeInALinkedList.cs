using Leetcode.Utilities;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/delete-node-in-a-linked-list/
    /// </summary>
    public class Medium237_DeleteNodeInALinkedList
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}