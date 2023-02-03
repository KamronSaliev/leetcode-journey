namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/rotate-array/
    /// </summary>
    public class Medium189_RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            var n = nums.Length;
            var rotated = new int[n];

            for (var i = 0; i < n; i++)
            {
                rotated[(i + k) % n] = nums[i];
            }

            for (var i = 0; i < n; i++)
            {
                nums[i] = rotated[i];
            }
        }
    }
}