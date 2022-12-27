namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/valid-palindrome/
    /// </summary>
    public class Easy125_ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            var startIndex = 0;
            var endIndex = s.Length - 1;

            while (startIndex < endIndex)
            {
                if (!char.IsLetterOrDigit(s[startIndex]))
                {
                    startIndex++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[endIndex]))
                {
                    endIndex--;
                    continue;
                }

                if (s[startIndex++] != s[endIndex--])
                {
                    return false;
                }
            }

            return true;
        }
    }
}