namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/remove-element/
    /// </summary>
    public class Easy27_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            var index = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index++] = nums[i];
                }
            }

            return index;
        }
    }
}