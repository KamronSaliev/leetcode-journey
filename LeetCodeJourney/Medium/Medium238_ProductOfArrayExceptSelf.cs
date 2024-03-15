namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/product-of-array-except-self
    /// </summary>
    public class Medium238_ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var products = new int[nums.Length];
            var num = 1;

            for (var i = 0; i < nums.Length; i++)
            {
                products[i] = num;
                num *= nums[i];
            }

            num = 1;

            for (var i = nums.Length - 1; i >= 0; i--)
            {
                products[i] *= num;
                num *= nums[i];
            }

            return products;
        }
    }
}