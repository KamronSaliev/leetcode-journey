namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/merge-sorted-array/
    /// </summary>
    public class Easy88_MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var i = m - 1;
            var j = n - 1;
            var position = nums1.Length - 1;

            while (position >= 0 && j >= 0)
            {
                nums1[position] = i >= 0 && nums1[i] > nums2[j] ? nums1[i--] : nums2[j--];
                position--;
            }
        }
    }
}