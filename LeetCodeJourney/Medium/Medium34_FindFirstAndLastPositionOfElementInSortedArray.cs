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

            result[0] = FindPosition(nums, target, true);
            result[1] = FindPosition(nums, target, false);

            return result;
        }

        private int FindPosition(int[] nums, int target, bool isFirst)
        {
            var left = 0;
            var right = nums.Length - 1;
            var index = -1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    index = mid;

                    if (isFirst)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
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

            return index;
        }
    }
}