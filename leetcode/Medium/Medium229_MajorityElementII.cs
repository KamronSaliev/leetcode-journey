using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/majority-element-ii/
    /// </summary>
    public class Medium229_MajorityElementII
    {
        public IList<int> MajorityElement(int[] nums)
        {
            int? candidate1 = null;
            int? candidate2 = null;
            var count1 = 0;
            var count2 = 0;

            foreach (var num in nums)
            {
                if (num == candidate1)
                {
                    count1++;
                }
                else if (num == candidate2)
                {
                    count2++;
                }
                else if (count1 == 0)
                {
                    candidate1 = num;
                    count1 = 1;
                }
                else if (count2 == 0)
                {
                    candidate2 = num;
                    count2 = 1;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }

            var result = new List<int>();

            if (nums.Count(n => n == candidate1) > nums.Length / 3)
            {
                if (candidate1 != null)
                {
                    result.Add(candidate1.Value);
                }
            }

            if (nums.Count(n => n == candidate2) > nums.Length / 3)
            {
                if (candidate2 != null)
                {
                    result.Add(candidate2.Value);
                }
            }

            return result;
        }
    }
}