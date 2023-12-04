using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    public class Easy21_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            var startNode = new ListNode();
            var curr = startNode;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    curr.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    curr.next = list2;
                    list2 = list2.next;
                }

                curr = curr.next;
            }

            curr.next = list1 ?? list2;

            return startNode.next;
        }
    }
}