using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/permutations/
    /// </summary>
    public class Medium46_Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();

            Backtrack(nums, new List<int>(), result);

            return result;
        }

        private void Backtrack(int[] nums, List<int> list, IList<IList<int>> result)
        {
            if (list.Count == nums.Length)
            {
                result.Add(new List<int>(list));
                return;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (list.Contains(nums[i]))
                {
                    continue;
                }

                list.Add(nums[i]);
                Backtrack(nums, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}