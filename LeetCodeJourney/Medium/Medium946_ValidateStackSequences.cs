using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/validate-stack-sequences/
    /// </summary>
    public class Medium946_ValidateStackSequences
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            var stack = new Stack<int>();
            var index = 0;

            for (var i = 0; i < pushed.Length; i++)
            {
                stack.Push(pushed[i]);
                while (stack.Count != 0 && stack.Peek() == popped[index])
                {
                    stack.Pop();
                    index++;
                }
            }

            return stack.Count == 0;
        }
    }
}