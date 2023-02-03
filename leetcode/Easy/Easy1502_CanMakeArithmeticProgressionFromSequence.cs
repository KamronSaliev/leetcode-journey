using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence/
    /// </summary>
    public class Easy1502_CanMakeArithmeticProgressionFromSequence
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);

            var difference = arr[1] - arr[0];

            for (var i = 2; i < arr.Length; i++)
            {
                var temp = arr[i] - arr[i - 1];

                if (difference != temp)
                {
                    return false;
                }
            }

            return true;
        }
    }
}