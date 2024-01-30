using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/evaluate-reverse-polish-notation/
    /// </summary>
    public class Medium150_EvaluateReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();

            foreach (var token in tokens)
            {
                if (token is "+" or "-" or "*" or "/")
                {
                    var right = stack.Pop();
                    var left = stack.Pop();
                    
                    var result = token switch
                    {
                        "+" => left + right,
                        "-" => left - right,
                        "*" => left * right,
                        "/" => left / right,
                        _ => throw new ArgumentOutOfRangeException()
                    };
                    
                    stack.Push(result);
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }

            return stack.Pop();
        }
    }
}