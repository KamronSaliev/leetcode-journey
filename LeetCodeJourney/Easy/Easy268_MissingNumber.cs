using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/missing-number/
    /// </summary>
    public class Easy268_MissingNumber
    {
        public int MissingNumber(int[] nums)
        {
            var occurrences = new Dictionary<int, int>();

            for (int i = 0; i <= nums.Length; i++)
            {
                occurrences.Add(i, 0);
            }
            
            for (var i = 0; i < nums.Length; i++)
            {
                occurrences[nums[i]]++;
            }

            foreach (var occurrence in occurrences)
            {
                if (occurrence.Value == 0)
                {
                    return occurrence.Key;
                }
            }

            return -1;
        }
    }
}