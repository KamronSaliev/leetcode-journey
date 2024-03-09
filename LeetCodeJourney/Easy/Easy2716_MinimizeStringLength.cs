using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/minimize-string-length/
    /// </summary>
    public class Easy2716_MinimizeStringLength
    {
        public int MinimizedStringLength(string s)
        {
            return new HashSet<char>(s).Count;
        }
    }
}