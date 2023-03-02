using System;
using System.Text;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/string-compression/
    /// </summary>
    public class Medium443_StringCompression
    {
        public int Compress(char[] chars)
        {
            var result = new StringBuilder();
            var currentChar = chars[0];
            var counter = 1;
            var item = string.Empty;

            for (var i = 1; i < chars.Length; i++)
            {
                if (chars[i] == currentChar)
                {
                    counter++;
                }
                else
                {
                    item = counter == 1 ? $"{currentChar}" : $"{currentChar}{counter}";
                    result.Append(item);

                    currentChar = chars[i];
                    counter = 1;
                }
            }

            item = counter == 1 ? $"{currentChar}" : $"{currentChar}{counter}";
            result.Append(item);

            for (var i = 0; i < result.Length; i++)
            {
                chars[i] = result[i];
            }

            return result.Length;
        }
    }
}