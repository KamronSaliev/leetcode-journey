using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/find-the-distance-value-between-two-arrays/
    /// </summary>
    public class Easy1385_FindTheDistanceValueBetweenTwoArrays
    {
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            var count = 0;

            Array.Sort(arr2);

            for (var i = 0; i < arr1.Length; i++)
            {
                var flag = true;

                var left = 0;
                var right = arr2.Length - 1;

                while (left <= right)
                {
                    var mid = left + (right - left) / 2;

                    if (Math.Abs(arr1[i] - arr2[mid]) <= d)
                    {
                        flag = false;
                        break;
                    }

                    if (arr1[i] > arr2[mid])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                if (flag)
                {
                    count++;
                }
            }

            return count;
        }
    }
}