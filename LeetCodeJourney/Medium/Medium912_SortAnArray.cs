namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/sort-an-array/
    /// </summary>
    public class Medium912_SortAnArray
    {
        public int[] SortArray(int[] nums)
        {
            MergeSort(nums, 0, nums.Length - 1);

            return nums;
        }

        private void MergeSort(int[] nums, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var mid = left + (right - left) / 2;
            MergeSort(nums, left, mid);
            MergeSort(nums, mid + 1, right);
            Merge(nums, left, right, mid);
        }

        private void Merge(int[] nums, int left, int right, int mid)
        {
            var i = 0;
            var j = 0;
            var n1 = mid - left + 1;
            var n2 = right - mid;
            var leftNums = new int[n1];
            var rightNums = new int[n2];

            while (i < n1)
            {
                leftNums[i] = nums[left + i];
                i++;
            }

            while (j < n2)
            {
                rightNums[j] = nums[mid + 1 + j];
                j++;
            }

            i = 0;
            j = 0;
            var k = left;

            while (i < n1 && j < n2)
            {
                if (leftNums[i] <= rightNums[j])
                {
                    nums[k++] = leftNums[i++];
                }
                else
                {
                    nums[k++] = rightNums[j++];
                }
            }

            while (i < n1)
            {
                nums[k++] = leftNums[i++];
            }

            while (j < n2)
            {
                nums[k++] = rightNums[j++];
            }
        }
    }
}