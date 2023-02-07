namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    /// </summary>
    public class Medium34_FindFirstAndLastPositionOfElementInSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var result = new[] { -1, -1 };

            result[0] = FindFirstPosition(nums, target);
            result[1] = FindLastPosition(nums, target);

            return result;
        }

        private int FindFirstPosition(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            var start = -1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    start = mid;
                    right = mid - 1;
                }
                else if (target > nums[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return start;
        }

        private int FindLastPosition(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            var end = -1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    end = mid;
                    left = mid + 1;
                }
                else if (target > nums[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return end;
        }
    }
}