using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/remove-linked-list-elements/
    /// </summary>
    public class Easy203_RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }

            var root = head;

            while (root != null && root.val == val)
            {
                root = root.next;
            }

            while (head.next != null)
            {
                if (head.next.val == val)
                {
                    head.next = head.next.next;
                }
                else
                {
                    head = head.next;
                }
            }

            return root;
        }
    }
}