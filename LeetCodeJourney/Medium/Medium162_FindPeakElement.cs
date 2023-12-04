namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-peak-element/
    /// </summary>
    public class Medium162_FindPeakElement
    {
        public int FindPeakElement(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] < nums[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return nums[left] > nums[right] ? left : right;
        }
    }
}