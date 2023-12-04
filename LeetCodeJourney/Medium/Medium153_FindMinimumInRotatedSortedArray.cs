namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
    /// </summary>
    public class Medium153_FindMinimumInRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] < nums[right])
                {
                    right = mid;
                }
                else if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
            }

            return nums[left];
        }
    }
}