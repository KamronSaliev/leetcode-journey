using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/check-if-n-and-its-double-exist/
    /// </summary>
    public class Easy1346_CheckIfNAndItsDoubleExist
    {
        public bool CheckIfExist(int[] arr)
        {
            Array.Sort(arr);

            for (var i = 0; i < arr.Length; i++)
            {
                var result = Search(arr, arr[i] * 2);

                if (result != i && result != -1)
                {
                    return true;
                }
            }

            return false;
        }

        private int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}