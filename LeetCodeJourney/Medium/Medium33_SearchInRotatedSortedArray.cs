namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/search-in-rotated-sorted-array/
    /// </summary>
    public class Medium33_SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }

                if (nums[mid] > nums[right]) // Mid is in the left part of the array
                {
                    if (target < nums[mid] && target >= nums[left])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else if (nums[mid] < nums[left]) // Mid is in the right part of the array
                {
                    if (target > nums[mid] && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else // No rotation
                {
                    if (target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }

            return -1;
        }
    }
}