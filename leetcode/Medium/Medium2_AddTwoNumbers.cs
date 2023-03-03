using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public class Medium2_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode();
            var carry = 0;
            var node = result;

            while (l1 != null || l2 != null || carry != 0)
            {
                var sum = carry;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
            
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
            
                carry = sum >= 10 ? 1 : 0;
                node.next = new ListNode(sum % 10);
                node = node.next;
            }

            return result.next;
        }
    }
}