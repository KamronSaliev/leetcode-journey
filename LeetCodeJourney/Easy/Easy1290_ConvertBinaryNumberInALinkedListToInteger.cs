using System;
using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
    /// </summary>
    public class Easy1290_ConvertBinaryNumberInALinkedListToInteger
    {
        public int GetDecimalValue(ListNode head)
        {
            var digits = new List<int>();

            while (head != null)
            {
                digits.Add(head.val);
                head = head.next;
            }

            var num = 0;
            var degree = digits.Count - 1;

            for (var i = 0; i < digits.Count; i++)
            {
                num += digits[i] * (int)Math.Pow(2, degree);
                degree--;
            }

            return num;
        }
    }
}