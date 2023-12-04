using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/decode-string/
    /// </summary>
    public class Medium394_DecodeString
    {
        public string DecodeString(string s)
        {
            var index = 0;

            return DecodeStringInner(s, ref index);
        }

        private string DecodeStringInner(string s, ref int index)
        {
            var multiplier = 0;
            var result = string.Empty;

            while (index < s.Length)
            {
                if (char.IsDigit(s[index]))
                {
                    var digit = s[index] - '0';
                    multiplier = multiplier * 10 + digit;

                    Console.WriteLine(multiplier);
                }
                else if (s[index] == '[')
                {
                    index++;

                    var stringInner = DecodeStringInner(s, ref index);

                    for (var j = 0; j < multiplier; j++)
                    {
                        result += stringInner;
                    }

                    multiplier = 0;
                }
                else if (s[index] == ']')
                {
                    return result;
                }
                else
                {
                    result += s[index];
                }

                index++;
            }

            return result;
        }
    }
}