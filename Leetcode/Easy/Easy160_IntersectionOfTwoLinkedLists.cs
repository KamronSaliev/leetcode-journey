using System.Collections.Generic;
using Leetcode.Utilities;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/intersection-of-two-linked-lists/
    /// </summary>
    public class Easy160_IntersectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            var listA = new List<ListNode>();
            var listB = new List<ListNode>();

            var currentA = headA;
            var currentB = headB;

            while (currentA != null || currentB != null)
            {
                if (currentA != null)
                {
                    if (listB.Contains(currentA))
                    {
                        return currentA;
                    }

                    listA.Add(currentA);
                    currentA = currentA.next;
                }

                if (currentB != null)
                {
                    if (listA.Contains(currentB))
                    {
                        return currentB;
                    }

                    listB.Add(currentB);
                    currentB = currentB.next;
                }
            }

            return null;
        }
    }
}