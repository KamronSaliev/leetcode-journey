using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/132-pattern/
    /// </summary>
    public class Medium456_132Pattern
    {
        public bool Find132pattern(int[] nums)
        {
            var stack = new Stack<int>();
            var max = int.MinValue;

            for (var i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] < max)
                {
                    return true;
                }

                while (stack.Count > 0 && stack.Peek() < nums[i])
                {
                    max = stack.Pop();
                }

                stack.Push(nums[i]);
            }

            return false;
        }
    }
}