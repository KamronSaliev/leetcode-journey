namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/move-zeroes/
    /// </summary>
    public class Easy283_MoveZeroes
    {
        public void MoveZeroes(int[] nums)
        {
            var counter = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    (nums[counter], nums[i]) = (nums[i], nums[counter]);
                    counter++;
                }
            }
        }
    }
}