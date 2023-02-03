namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    public class Easy26_RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            var k = 0;
            var counter = 0;

            if (nums.Length == 0)
            {
                return 0;
            }

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    counter++;
                }
                else
                {
                    nums[i - counter] = nums[i];
                    k++;
                }
            }

            return k + 1;
        }
    }
}