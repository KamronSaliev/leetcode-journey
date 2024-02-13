namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/find-first-palindromic-string-in-the-array/
    /// </summary>
    public class Easy2108_FindFirstPalindromicStringInTheArray
    {
        public string FirstPalindrome(string[] words)
        {
            foreach (var word in words)
            {
                if (IsPalindrome(word, 0, word.Length - 1))
                {
                    return word;
                }
            }

            return string.Empty;
        }

        private bool IsPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start++] != s[end--])
                {
                    return false;
                }
            }

            return true;
        }
    }
}