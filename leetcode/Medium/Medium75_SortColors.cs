namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/sort-colors/
    /// </summary>
    public class Medium75_SortColors
    {
        public void SortColors(int[] nums)
        {
            // nums array is sorted using two pointers for 0's and 2's respectively
            var left = 0;
            var right = nums.Length - 1;
            var i = 0;

            while (i <= right)
            {
                switch (nums[i])
                {
                    case 0:
                        (nums[i], nums[left]) = (nums[left], nums[i]);
                        left++;
                        i++;
                        break;
                    case 1:
                        i++;
                        break;
                    case 2:
                        (nums[i], nums[right]) = (nums[right], nums[i]);
                        right--;
                        break;
                }
            }
        }
    }
}