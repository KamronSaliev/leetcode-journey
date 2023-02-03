namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-palindrome/
    /// </summary>
    public class Easy409_LongestPalindrome
    {
        public int LongestPalindrome(string s)
        {
            var lowercase = new int[26];
            var uppercase = new int[26];
            var count = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] - 'a' < 0)
                {
                    uppercase[s[i] - 'A']++;
                }
                else
                {
                    lowercase[s[i] - 'a']++;
                }
            }

            for (var i = 0; i < 26; i++)
            {
                count += lowercase[i] / 2 * 2;
                count += uppercase[i] / 2 * 2;
            }

            return count;
        }
    }
}