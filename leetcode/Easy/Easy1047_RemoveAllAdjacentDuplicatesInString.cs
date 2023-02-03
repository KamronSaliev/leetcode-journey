using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
    /// </summary>
    public class Easy1047_RemoveAllAdjacentDuplicatesInString
    {
        public string RemoveDuplicates(string s)
        {
            var charStack = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (charStack.Count != 0 && charStack.Peek() == s[i])
                {
                    charStack.Pop();
                }
                else
                {
                    charStack.Push(s[i]);
                }
            }

            return string.Join(null, charStack.Reverse());
        }
    }
}