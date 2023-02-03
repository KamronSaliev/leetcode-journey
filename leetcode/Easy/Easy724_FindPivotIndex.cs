namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/find-pivot-index/
    /// </summary>
    public class Easy724_FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            var totalSum = 0;
            var leftSum = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                totalSum += nums[i];
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (leftSum * 2 == totalSum - nums[i])
                {
                    return i;
                }

                leftSum += nums[i];
            }

            return -1;
        }
    }
}