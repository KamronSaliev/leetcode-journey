using System;
using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public class Easy20_ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var ch in s)
            {
                if (IsOpeningBracket(ch))
                {
                    stack.Push(ch);
                    continue;
                }

                if (stack.Count == 0)
                {
                    return false;
                }

                var top = stack.Pop();

                if (GetMatchingOpeningBracket(ch) != top)
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }

        private bool IsOpeningBracket(char ch)
        {
            return ch == '(' || ch == '[' || ch == '{';
        }

        private char GetMatchingOpeningBracket(char ch)
        {
            switch (ch)
            {
                case ')':
                    return '(';
                case ']':
                    return '[';
                case '}':
                    return '{';
            }

            throw new Exception();
        }
    }
}