using System.Collections.Generic;
using Leetcode.Utilities;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/palindrome-linked-list/
    /// </summary>
    public class Easy234_PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            var current = head;
            var values = new List<int>();

            values.Add(current.val);
            
            while (current.next != null)
            {
                values.Add(current.next.val);
                current = current.next;
            }

            for (var i = 0; i < values.Count / 2; i++)
            {
                if (values[i] != values[values.Count - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}