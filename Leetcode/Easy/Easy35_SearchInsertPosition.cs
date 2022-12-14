namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/search-insert-position/
    /// </summary>
    public class Easy35_SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;
        }
    }
}