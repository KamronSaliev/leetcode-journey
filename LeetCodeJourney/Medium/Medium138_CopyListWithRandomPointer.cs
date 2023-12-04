using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/copy-list-with-random-pointer/
    /// </summary>
    public class Medium138_CopyListWithRandomPointer
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }

            var dictionary = new Dictionary<Node, Node>();

            var current = head;
            while (current != null)
            {
                dictionary[current] = new Node(current.val);
                current = current.next;
            }

            current = head;
            while (current != null)
            {
                dictionary[current].next = current.next != null ? dictionary[current.next] : null;
                dictionary[current].random = current.random != null ? dictionary[current.random] : null;
                current = current.next;
            }

            return dictionary[head];
        }
    }
}