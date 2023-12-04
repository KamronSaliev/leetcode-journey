namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
    /// </summary>
    public class Medium81_SearchInRotatedSortedArrayII
    {
        public bool Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return true;
                }

                if (nums[left] == nums[mid])
                {
                    left++;
                    continue;
                }

                if (nums[left] <= nums[mid])
                {
                    if (nums[left] <= target && target <= nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (nums[mid] <= target && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return false;
        }
    }
}