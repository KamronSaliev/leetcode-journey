namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/kth-missing-positive-number/
    /// </summary>
    public class Easy1539_KthMissingPositiveNumber
    {
        public int FindKthPositive(int[] arr, int k)
        {
            var left = 0;
            var right = arr.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (arr[mid] - mid - 1 < k)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left + k;
        }
    }
}