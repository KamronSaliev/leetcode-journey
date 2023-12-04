using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/max-dot-product-of-two-subsequences/
    /// </summary>
    public interface Hard1458_MaxDotProductOfTwoSubsequences
    {
        public int MaxDotProduct(int[] nums1, int[] nums2)
        {
            var n = nums1.Length;
            var m = nums2.Length;
            var current = new int[m + 1];
            var previous = new int[m + 1];

            Array.Fill(current, int.MinValue);
            Array.Fill(previous, int.MinValue);

            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= m; j++)
                {
                    var product = nums1[i - 1] * nums2[j - 1];
                    current[j] = Math.Max(Math.Max(Math.Max(product, previous[j]), current[j - 1]),
                        product + Math.Max(0, previous[j - 1]));
                }

                (current, previous) = (previous, current);
            }

            return previous[m];
        }
    }
}