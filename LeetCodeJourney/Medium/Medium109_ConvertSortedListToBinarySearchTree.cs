using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/
    /// </summary>
    public class Medium109_ConvertSortedListToBinarySearchTree
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            var nums = GetValues(head);

            return InsertToBST(nums, 0, nums.Count - 1);
        }

        private TreeNode InsertToBST(List<int> nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            var mid = left + (right - left) / 2;
            var node = new TreeNode(nums[mid])
            {
                left = InsertToBST(nums, left, mid - 1),
                right = InsertToBST(nums, mid + 1, right)
            };

            return node;
        }

        private List<int> GetValues(ListNode head)
        {
            var values = new List<int>();

            while (head != null)
            {
                values.Add(head.val);
                head = head.next;
            }

            return values;
        }
    }
}