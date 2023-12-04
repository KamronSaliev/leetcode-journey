namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-common-value/
    /// </summary>
    public class Easy2540_MinimumCommonValue
    {
        public int GetCommon(int[] nums1, int[] nums2)
        {
            for (int i = 0; i < nums1.Length; i++)
            {
                var index = Search(nums2, nums1[i]);

                if (index != -1)
                {
                    return nums2[index];
                }
            }

            return -1;
        }
        
        private int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

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

            return -1;
        }
    }
}