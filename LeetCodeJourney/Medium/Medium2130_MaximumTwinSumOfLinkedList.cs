using System;
using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/
    /// </summary>
    public class Medium2130_MaximumTwinSumOfLinkedList
    {
        public int PairSum(ListNode head)
        {
            var slow = head;
            var fast = head.next;

            var nodes = new List<int> { slow.val };

            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                nodes.Add(slow.val);
            }

            var maxTwinSum = int.MinValue;
            
            for (var i = nodes.Count - 1; i >= 0; i--)
            {
                slow = slow.next;
                
                nodes[i] += slow.val;
                
                maxTwinSum = Math.Max(maxTwinSum, nodes[i]);
            }

            return maxTwinSum;
        }
    }
}