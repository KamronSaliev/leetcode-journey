using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/length-of-last-word/
    /// </summary>
    public class Easy58_LengthOfLastWord
    {
        public int LengthOfLastWord(string s)
        {
            var lastWord = s.Trim().Split().LastOrDefault();
            return lastWord?.Length ?? 0;
        }
    }
}