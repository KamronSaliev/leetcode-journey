namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-palindromic-substring/
    /// </summary>
    public class Medium5_LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            var startIndex = 0;
            var longestLength = 1;

            for (var i = 0; i < s.Length; i++)
            {
                var right = i;
                while (right < s.Length && s[i] == s[right])
                {
                    right++;
                }

                var left = i - 1;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    left--;
                    right++;
                }

                var currentLength = right - left - 1;
                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    startIndex = left + 1;
                }
            }

            return s.Substring(startIndex, longestLength);
        }
    }
}