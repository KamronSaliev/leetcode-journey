using System.Collections.Generic;

namespace LeetCode.Easy
{
    public class Easy228_SummaryRanges
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            var result = new List<string>();
            var start = 0;
            var end = 0;

            while (end < nums.Length)
            {
                if (end + 1 < nums.Length && nums[end] + 1 == nums[end + 1])
                {
                    end++;
                }
                else
                {
                    result.Add(start == end ? nums[start].ToString() : $"{nums[start]}->{nums[end]}");
                    start = end + 1;
                    end = start;
                }
            }

            return result;
        }
    }
}