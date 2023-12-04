using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/contains-duplicate/
    /// </summary>
    public class Easy217_ContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var dict = new Dictionary<int, bool>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    return true;
                }

                dict.Add(nums[i], true);
            }

            return false;
        }
    }
}