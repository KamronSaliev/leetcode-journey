namespace LeetCode.Medium
{
    public class Medium540_SingleElementInASortedArray
    {
        public int SingleNonDuplicate(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            if (nums.Length == 1 || nums[0] != nums[1])
            {
                return nums[left];
            }

            if (nums[^1] != nums[^2])
            {
                return nums[^1];
            }

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] != nums[mid - 1] && nums[mid] != nums[mid + 1])
                {
                    return nums[mid];
                }

                if (nums[mid] == nums[mid + 1] && mid % 2 == 0 || nums[mid] == nums[mid - 1] && mid % 2 != 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return nums[left];
        }
    }
}