namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/sort-array-by-parity/
    /// </summary>
    public class Easy905_SortArrayByParity
    {
        public int[] SortArrayByParity(int[] nums)
        {
            var i = 0;
            var j = nums.Length - 1;

            while (i < j)
            {
                while (i < j && nums[i] % 2 == 0)
                {
                    i++;
                }

                while (i < j && nums[j] % 2 != 0)
                {
                    j--;
                }

                Swap(ref nums[i], ref nums[j]);
            }

            return nums;
        }

        private void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
    }
}