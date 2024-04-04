using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses
    /// </summary>
    public class Easy1614_MaximumNestingDepthOfTheParentheses
    {
        public int MaxDepth(string s)
        {
            var count = 0;
            var result = 0;

            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                        count++;
                        result = Math.Max(result, count);
                        break;
                    case ')':
                        count--;
                        break;
                }
            }

            return result;
        }
    }
}