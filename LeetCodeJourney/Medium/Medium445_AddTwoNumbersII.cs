using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/add-two-numbers-ii/
    /// </summary>
    public class Medium445_AddTwoNumbersII
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var reversedL1 = ReverseLinkedList(l1);
            var reversedL2 = ReverseLinkedList(l2);

            var dummyHead = new ListNode();
            var current = dummyHead;
            var carry = 0;

            while (reversedL1 != null || reversedL2 != null || carry != 0)
            {
                var sum = carry;

                if (reversedL1 != null)
                {
                    sum += reversedL1.val;
                    reversedL1 = reversedL1.next;
                }

                if (reversedL2 != null)
                {
                    sum += reversedL2.val;
                    reversedL2 = reversedL2.next;
                }

                current.next = new ListNode(sum % 10);
                current = current.next;
                carry = sum / 10;
            }

            return ReverseLinkedList(dummyHead.next);
        }

        private ListNode ReverseLinkedList(ListNode head)
        {
            ListNode previous = null;
            var current = head;

            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            return previous;
        }
    }
}