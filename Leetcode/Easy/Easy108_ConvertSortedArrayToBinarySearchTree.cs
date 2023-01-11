using Leetcode.Utilities;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    /// </summary>
    public class Easy108_ConvertSortedArrayToBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return InsertToBST(nums, 0, nums.Length - 1);
        }

        private TreeNode InsertToBST(int[] nums, int left, int right)
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
    }
}