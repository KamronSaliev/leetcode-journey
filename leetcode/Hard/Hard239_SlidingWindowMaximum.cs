using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/sliding-window-maximum/
    /// </summary>
    public class Hard239_SlidingWindowMaximum
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var list = new LinkedList<int>();
            var result = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (list.First != null && list.Count > 0 && list.First.Value < i - k + 1)
                {
                    list.RemoveFirst();
                }

                while (list.Last != null && list.Count > 0 && nums[list.Last.Value] < nums[i])
                {
                    list.RemoveLast();
                }

                list.AddLast(i);

                if (i < k - 1)
                {
                    continue;
                }

                if (list.First != null)
                {
                    result.Add(nums[list.First.Value]);
                }
            }

            return result.ToArray();
        }
    }
}