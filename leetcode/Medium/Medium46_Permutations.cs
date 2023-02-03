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
            var ans = new List<IList<int>>();

            Backtrack(nums, new List<int>(), ans);

            return ans;
        }

        private void Backtrack(int[] nums, List<int> list, IList<IList<int>> ans)
        {
            if (list.Count == nums.Length)
            {
                ans.Add(new List<int>(list));
                return;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (list.Contains(nums[i]))
                {
                    continue;
                }

                list.Add(nums[i]);
                Backtrack(nums, list, ans);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}