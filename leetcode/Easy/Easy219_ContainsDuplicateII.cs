using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/contains-duplicate-ii/
    /// </summary>
    public class Easy219_ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    if (i - dictionary[nums[i]] <= k)
                    {
                        return true;
                    }
                    else
                    {
                        dictionary[nums[i]] = i;
                    }
                }
                else
                {
                    dictionary.Add(nums[i], i);
                }
            }

            return false;
        }
    }
}