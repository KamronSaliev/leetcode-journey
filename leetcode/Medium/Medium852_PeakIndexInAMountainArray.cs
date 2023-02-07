namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/peak-index-in-a-mountain-array/
    /// </summary>
    public class Medium852_PeakIndexInAMountainArray
    {
        public int PeakIndexInMountainArray(int[] arr)
        {
            var left = 0;
            var right = arr.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (arr[mid] < arr[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;
        }
    }
}