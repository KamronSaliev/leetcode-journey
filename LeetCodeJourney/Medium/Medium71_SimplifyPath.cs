using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/simplify-path/
    /// </summary>
    public class Medium71_SimplifyPath
    {
        public string SimplifyPath(string path)
        {
            var directories = path
                .Replace("//", "/")
                .Split('/', StringSplitOptions.RemoveEmptyEntries);

            var stack = new Stack<string>();
            foreach (var directory in directories)
            {
                switch (directory)
                {
                    case ".." when stack.Count > 0:
                        stack.Pop();
                        break;
                    case ".":
                    case "..":
                        break;
                    default:
                        stack.Push(directory);
                        break;
                }
            }

            var sb = new StringBuilder();
            while (stack.Count > 0)
            {
                sb.Insert(0, $"/{stack.Pop()}");
            }

            if (sb.Length == 0)
            {
                sb.Append('/');
            }

            return sb.ToString();
        }
    }
}