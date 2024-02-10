namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/palindromic-substrings/
    /// </summary>
    public class Medium647_PalindromicSubstrings
    {
        public int CountSubstrings(string s)
        {
            var result = 0;

            for (var i = 0; i < 2 * s.Length - 1; i++)
            {
                var left = i / 2;
                var right = left + i % 2;

                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    result++;
                    left--;
                    right++;
                }
            }

            return result;
        }
    }
}